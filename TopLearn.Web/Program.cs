using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using TopLearn.Core.Convertors;
using TopLearn.Core.Services;
using TopLearn.Core.Services;
using TopLearn.Core.Services.Interfaces;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);

// -------------------------------------------------------------
// 🧩 Configuration
// -------------------------------------------------------------
var configuration = builder.Configuration;

// -------------------------------------------------------------
// 🧰 Service Registration
// -------------------------------------------------------------
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// ✅ اگر نیاز به محدودیت آپلود فایل داری، فعال کن
// builder.Services.Configure<FormOptions>(options => { options.MultipartBodyLengthLimit = 6000000; });

// -------------------------------------------------------------
// 🔐 Authentication (Cookie-based)
// -------------------------------------------------------------
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
});

// -------------------------------------------------------------
// 🗄️ Database Context
// -------------------------------------------------------------
builder.Services.AddDbContext<TopLearnContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("TopLearnConnection"));
});


// تنظیم URL از appsettings
var urlsConfig = builder.Configuration["ApplicationUrlConfiguration:ApplicationUrl"];
if (!string.IsNullOrEmpty(urlsConfig))
{
    var urls = urlsConfig.Split(',', StringSplitOptions.RemoveEmptyEntries);
    builder.WebHost.UseUrls(urls);
}

// -------------------------------------------------------------
// 🧩 Dependency Injection (IoC)
// -------------------------------------------------------------
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IViewRenderService, RenderViewToString>();
builder.Services.AddTransient<IPermissionService, PermissionService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IForumService, ForumService>();
builder.Services.AddScoped<IMockPaymentService, MockPaymentService>();


// -------------------------------------------------------------
// 🚀 Build Application
// -------------------------------------------------------------
var app = builder.Build();


//seed Data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TopLearnContext>();
    context.Database.Migrate();
}
// -------------------------------------------------------------
// ⚙️ Custom Middlewares
// -------------------------------------------------------------

// Middleware 1: Redirect 404 to /Home/Error404
app.Use(async (context, next) =>
{
    await next();

    if (context.Response.StatusCode == 404)
    {
        context.Response.Redirect("/Home/Error404");
    }
});

// Middleware 2: Check CourseFilesOnline access
app.Use(async (context, next) =>
{
    if (context.Request.Path.Value!.ToLower().StartsWith("/coursefilesonline"))
    {


        // دریافت Configuration از سرویس‌ها
        var configuration = context.RequestServices.GetRequiredService<IConfiguration>();

        // خواندن دامنه‌های مجاز از appsettings
        var baseUrl = configuration["ApplicationUrlConfiguration:BaseUrl"];
        var applicationUrls = configuration["ApplicationUrlConfiguration:ApplicationUrls"]?
            .Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        // ایجاد لیست دامنه‌های مجاز
        var allowedDomains = new List<string>();
        if (!string.IsNullOrEmpty(baseUrl))
            allowedDomains.Add(baseUrl);
        allowedDomains.AddRange(applicationUrls);
        var referer = context.Request.Headers["Referer"].ToString();
        if (!string.IsNullOrEmpty(referer) && allowedDomains.Any(domain => referer.StartsWith(domain)))
        {
            await next.Invoke();
        }
        else
        {
            context.Response.Redirect("/Login");
        }
    }
    else
    {
        await next.Invoke();
    }
});

// -------------------------------------------------------------
// 🌍 Middleware Pipeline
// -------------------------------------------------------------
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// -------------------------------------------------------------
// 🧭 Routing (replaces UseMvc)
// -------------------------------------------------------------
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// -------------------------------------------------------------
// 🚀 Run App
// -------------------------------------------------------------
app.Run();
