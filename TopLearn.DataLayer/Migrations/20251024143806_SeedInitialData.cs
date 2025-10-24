using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Linq;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TopLearn.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseGroups",
                columns: new[] { "GroupId", "GroupTitle", "IsDelete", "ParentId" },
                values: new object[,]
                {
                    { -7, "سیستم عامل", false, null },
                    { -6, "سئو", false, null },
                    { -5, "بانک های اطلاعاتی", false, null },
                    { -4, "طراحی سایت", false, null },
                    { -3, "برنامه نویسی تحت ویندوز", false, null },
                    { -2, "برنامه‌نویسی وب", false, null },
                    { -1, "برنامه نویسی موبایل", false, null }
                });

            migrationBuilder.InsertData(
                table: "CourseLevels",
                columns: new[] { "LevelId", "LevelTitle" },
                values: new object[,]
                {
                    { -4, "فوق پیشرفته" },
                    { -3, "پیشرفته" },
                    { -2, "متوسط" },
                    { -1, "مقدماتی" }
                });

            migrationBuilder.InsertData(
                table: "CourseStatuses",
                columns: new[] { "StatusId", "StatusTitle" },
                values: new object[,]
                {
                    { -2, "دوره به اتمام رسیده است" },
                    { -1, "دوره در حال برگزاری است" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "PermissionId", "ParentID", "PermissionTitle" },
                values: new object[] { -1, null, "پنل مدیریت" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "IsDelete", "RoleTitle" },
                values: new object[,]
                {
                    { -3, false, "کاربر عادی" },
                    { -2, false, "استاد" },
                    { -1, false, "مدیر سایت" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActiveCode", "Email", "IsActive", "IsDelete", "Password", "RegisterDate", "UserAvatar", "UserName" },
                values: new object[,]
                {
                    { -4, "RezaActiveCode", "Reza@Gmail.com", true, false, "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5c426500629418a8093b899d2deaced.jpg", "رضا جویباری" },
                    { -3, "NazaninActiveCode", "Nazanin@Gmail.com", true, false, "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "46895918151d44069832d66cbb880534.jpg", "نازنین سهروردی" },
                    { -2, "MahdiAminiActiveCode", "MahdiAmini@Gmail.com", true, false, "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ed75d864648641f3b5440d43447470bc.jpg", "مهدی امینی" },
                    { -1, "AdministratorActiveCode", "Admin@Gmail.com", true, false, "26-DC-31-89-42-68-58-72-CF-79-C5-EB-96-C9-BB-13", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "427b6fa79ef542f2956586ec88990c8d.jpg", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "WalletTypes",
                columns: new[] { "TypeId", "TypeTitle" },
                values: new object[,]
                {
                    { -2, "برداشت" },
                    { -1, "واریز" }
                });

            migrationBuilder.InsertData(
                table: "CourseGroups",
                columns: new[] { "GroupId", "GroupTitle", "IsDelete", "ParentId" },
                values: new object[,]
                {
                    { -708, "PowerShell", false, -7 },
                    { -707, "Shell Scripting", false, -7 },
                    { -706, "Kubernetes", false, -7 },
                    { -705, "Docker", false, -7 },
                    { -704, "Virtualization", false, -7 },
                    { -703, "macOS", false, -7 },
                    { -702, "Linux", false, -7 },
                    { -701, "Windows", false, -7 },
                    { -608, "سئو اپلیکیشن", false, -6 },
                    { -607, "آموزش Google Search Console", false, -6 },
                    { -606, "آموزش Google Analytics", false, -6 },
                    { -605, "تحقیق کلمات کلیدی", false, -6 },
                    { -604, "سئو محلی (Local SEO)", false, -6 },
                    { -603, "سئو تکنیکال (Technical SEO)", false, -6 },
                    { -602, "سئو خارجی (Off-Page SEO)", false, -6 },
                    { -601, "سئو داخلی (On-Page SEO)", false, -6 },
                    { -509, "NoSQL Databases", false, -5 },
                    { -508, "Database Design", false, -5 },
                    { -507, "SQLite", false, -5 },
                    { -506, "Redis", false, -5 },
                    { -505, "MongoDB", false, -5 },
                    { -504, "Oracle", false, -5 },
                    { -503, "PostgreSQL", false, -5 },
                    { -502, "MySQL", false, -5 },
                    { -501, "SQL Server", false, -5 },
                    { -409, "Adobe XD", false, -4 },
                    { -408, "Figma", false, -4 },
                    { -407, "UI/UX Design", false, -4 },
                    { -406, "SASS/SCSS", false, -4 },
                    { -405, "Tailwind CSS", false, -4 },
                    { -404, "Bootstrap", false, -4 },
                    { -403, "jQuery", false, -4 },
                    { -402, "JavaScript", false, -4 },
                    { -401, "HTML & CSS", false, -4 },
                    { -306, "WinUI", false, -3 },
                    { -305, "Windows Services", false, -3 },
                    { -304, "Console Applications", false, -3 },
                    { -303, "UWP", false, -3 },
                    { -302, "WPF", false, -3 },
                    { -301, "Windows Forms", false, -3 },
                    { -208, "Full Stack Development", false, -2 },
                    { -207, "Frontend Development", false, -2 },
                    { -206, "Ruby on Rails", false, -2 },
                    { -205, "Node.js", false, -2 },
                    { -204, "Spring Boot", false, -2 },
                    { -203, "Django", false, -2 },
                    { -202, "PHP Laravel", false, -2 },
                    { -201, "ASP.NET Core", false, -2 },
                    { -108, "Swift", false, -1 },
                    { -107, "Kotlin", false, -1 },
                    { -106, "Ionic", false, -1 },
                    { -105, "Xamarin", false, -1 },
                    { -104, "Flutter", false, -1 },
                    { -103, "React Native", false, -1 },
                    { -102, "iOS", false, -1 },
                    { -101, "اندروید (Android)", false, -1 }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "PermissionId", "ParentID", "PermissionTitle" },
                values: new object[,]
                {
                    { -5, -1, "مدیریت کدهای تخفیف" },
                    { -4, -1, "مدیریت دوره‌ها" },
                    { -3, -1, "مدیریت نقش ها" },
                    { -2, -1, "مدیریت کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RP_Id", "PermissionId", "RoleId" },
                values: new object[] { -1, -1, -1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UR_Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { -5, -2, -4 },
                    { -4, -2, -3 },
                    { -3, -2, -2 },
                    { -2, -2, -1 },
                    { -1, -1, -1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDescription", "CourseImageName", "CoursePrice", "CourseTitle", "CreateDate", "DemoFileName", "GroupId", "LevelId", "StatusId", "SubGroup", "Tags", "TeacherId", "UpdateDate" },
                values: new object[,]
                {
                    { -12, "یادگیری اصول برنامه‌نویسی با JavaScript.\r\n\r\nسرفصل‌ها:\r\n- Variables و Data Types\r\n- Functions\r\n- DOM Manipulation\r\n- Events\r\n- ES6+ Features", "cbfb83419c7f489a93a18072a42b16c4.jpg", 0, "آموزش JavaScript برای مبتدیان", new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "javascript-demo.mp4", -4, -1, -2, -402, "JavaScript,Programming,Free Course,Beginners", -4, null },
                    { -11, "دوره رایگان برای شروع یادگیری طراحی وب با HTML و CSS.\r\n\r\nمباحث covered:\r\n- HTML5 Semantics\r\n- CSS3 Fundamentals\r\n- Flexbox و Grid\r\n- Responsive Design\r\n- CSS Animations", "df04d23e71d5483fb0b33bb8ca3e0036.jpg", 0, "آموزش رایگان HTML و CSS - مقدماتی", new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "html-css-demo.mp4", -4, -1, -2, -401, "HTML,CSS,Frontend,Free Course", -3, null },
                    { -10, "یادگیری اصول طراحی رابط کاربری و تجربه کاربری با Figma.\r\n\r\nسرفصل‌ها:\r\n- Design Principles\r\n- User Research\r\n- Wireframing\r\n- Prototyping\r\n- Design Systems\r\n- Collaboration در Figma", "cc2e5dd085224351a743992ed58d6f5f.jpg", 380000, "آموزش طراحی UI/UX با Figma", new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "figma-demo.mp4", -4, -1, -2, -407, "UI/UX,Figma,Design,User Research", -2, null },
                    { -9, "مدیریت برنامه‌ها با Docker و Kubernetes.\r\n\r\nمباحث اصلی:\r\n- Docker Fundamentals\r\n- Docker Compose\r\n- Container Orchestration\r\n- CI/CD Pipelines\r\n- Monitoring و Logging", "8a29ceb69d0d445fa5a84a23f8289fc1.jpg", 600000, "آموزش Docker و Containerization", new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "docker-demo.mp4", -7, -3, -2, -705, "Docker,Container,DevOps,Kubernetes,CI/CD", -2, null },
                    { -8, "یادگیری کار با MongoDB برای برنامه‌های مدرن.\r\n\r\nسرفصل‌ها:\r\n- MongoDB Fundamentals\r\n- CRUD Operations\r\n- Aggregation Framework\r\n- Indexing\r\n- Replication و Sharding\r\n- Integration با .NET", "7c394f471bae4a52a6fc1f66bd8e9da1.jpg", 520000, "آموزش MongoDB - پایگاه داده NoSQL", new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "mongodb-demo.mp4", -5, -3, -1, -505, "MongoDB,NoSQL,Database,Aggregation", -2, null },
                    { -7, "مهارت‌های ضروری برای کار با SQL Server و نوشتن Queryهای بهینه.\r\n\r\nمباحث covered:\r\n- Database Design\r\n- T-SQL Programming\r\n- Stored Procedures و Functions\r\n- Indexing و Performance Tuning\r\n- Security و Permissions\r\n- Backup و Recovery", "dc8910af08ab41e0b69a1ef9e5b6b5c4.jpg", 480000, "آموزش جامع SQL Server و T-SQL", new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "sql-server-demo.mp4", -5, -2, -2, -501, "SQL Server,Database,T-SQL,SQL,Performance", -4, null },
                    { -6, "یادگیری توسعه اپلیکیشن‌های موبایل برای iOS و Android با React Native.\r\n\r\nسرفصل‌ها:\r\n- React Native Fundamentals\r\n- Navigation\r\n- State Management\r\n- Native Modules\r\n- Performance Optimization\r\n- Publishing to Stores", "9ec1c01ac39548aebfc4dce97c08bb74.jpg", 680000, "توسعه اپلیکیشن‌های Cross-Platform با React Native", new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "react-native-demo.mp4", -1, -3, -2, -103, "React Native,Mobile,Cross-Platform,JavaScript", -3, null },
                    { -5, "توسعه اپلیکیشن‌های مدرن Android با Kotlin و Android Jetpack.\r\n\r\nمباحث اصلی:\r\n- Kotlin Fundamentals\r\n- Android Jetpack Components\r\n- Room Database\r\n- WorkManager\r\n- Navigation Component\r\n- Testing", "38b32431b36d4833b65eeefaa9e50f21.jpg", 750000, "آموزش توسعه اپلیکیشن Android با Kotlin", new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "android-demo.mp4", -1, -2, -2, -101, "Android,Kotlin,Mobile Development,Jetpack", -2, null },
                    { -4, "TypeScript زبان برنامه‌نویسی مدرن که توسعه JavaScript را متحول کرده است.\r\n\r\nسرفصل‌ها:\r\n- Types و Interfaces\r\n- Generics\r\n- Decorators\r\n- Integration با React و Angular\r\n- Advanced Types\r\n- Project Configuration", "e06bfeed4f8d40e99a1804bd0fae60d7.jpg", 450000, "آموزش TypeScript برای توسعه‌دهندگان JavaScript", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "typescript-demo.mp4", -2, -2, -1, -207, "TypeScript,JavaScript,Frontend,Programming", -2, null },
                    { -3, "یادگیری React.js به همراه پروژه‌های عملی و واقعی. از مفاهیم پایه تا hooks پیشرفته.\r\n\r\nمباحث covered:\r\n- Components و JSX\r\n- State و Props\r\n- Hooks (useState, useEffect, useContext)\r\n- Routing با React Router\r\n- State Management با Context API و Redux\r\n- Testing با Jest\r\n- Deployment", "2db60db10ed347b590d08719ce6f5668.jpg", 550000, "آموزش React.js - توسعه رابط کاربری مدرن", new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "react-demo.mp4", -2, -2, -2, -207, "React.js,JavaScript,Frontend,Hooks,Redux", -4, null },
                    { -2, "در این دوره پیشرفته، شما یاد خواهید گرفت چگونه APIهای RESTful حرفه‌ای با ASP.NET Core بسازید.\r\n\r\nسرفصل‌های دوره:\r\n- طراحی RESTful API\r\n- Versioning در Web API\r\n- Documentation با Swagger/OpenAPI\r\n- Caching و Performance Optimization\r\n- Security (JWT, OAuth2)\r\n- Rate Limiting\r\n- Background Services\r\n- Integration Testing", "2030ac10cf1e4679b8d0e0c9d7751fe1.jpg", 650000, "آموزش پیشرفته Web API در ASP.NET Core", new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "web-api-demo.mp4", -2, -3, -2, -201, "ASP.NET Core,Web API,RESTful,JWT,Swagger,Performance", -3, null },
                    { -1, "در این دوره جامع، شما با فریمورک قدرتمند ASP.NET Core 9 آشنا خواهید شد. از مباحث پایه مانند Routing و Middleware تا مباحث پیشرفته مانند CQRS Pattern، Clean Architecture و Microservices.\r\n                     مباحث اصلی دوره :   \r\n                    - اصول پایه ASP.NET Core 9\r\n                    - معماری MVC و Web API\r\n                    - Entity Framework Core 9\r\n                    - Identity و سیستم احراز هویت\r\n                    - SignalR برای برنامه‌های Real-time\r\n                    - تست نویسی (Unit Test & Integration Test)\r\n                    - DevOps\r\n\r\nاین دوره مناسب توسعه‌دهندگان .NET است که می‌خواهند به صورت حرفه‌ای با ASP.NET Core کار کنند.", "24af9d08a5fe440a8d49840afa9ed208.jpg", 850000, "آموزش کامل ASP.NET Core 9 - از صفر تا صد", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aspnet-core-demo.mp4", -2, -2, -2, -201, "ASP.NET Core,Web Development,C#,MVC,Web API,Entity Framework", -2, null }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "PermissionId", "ParentID", "PermissionTitle" },
                values: new object[,]
                {
                    { -53, -5, "حذف کدهای تخفیف" },
                    { -52, -5, "ویرایش کدهای تخفیف" },
                    { -51, -5, "ایجاد کدهای تخفیف" },
                    { -43, -4, "حذف دوره ها" },
                    { -42, -4, "ویرایش دوره ها" },
                    { -41, -4, "ایجاد دوره ها" },
                    { -33, -3, "حذف نقش ها" },
                    { -32, -3, "ویرایش نقش ها" },
                    { -31, -3, "افزودن نقش ها" },
                    { -23, -2, "حذف کاربران" },
                    { -22, -2, "ویرایش کاربران" },
                    { -21, -2, "افزودن کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RP_Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { -18, -4, -2 },
                    { -5, -5, -1 },
                    { -4, -4, -1 },
                    { -3, -3, -1 },
                    { -2, -2, -1 }
                });

            migrationBuilder.InsertData(
                table: "CourseEpisodes",
                columns: new[] { "EpisodeId", "CourseId", "EpisodeFileName", "EpisodeTime", "EpisodeTitle", "IsFree" },
                values: new object[,]
                {
                    { -66, -12, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 20, 0, 0), "Events و Event Handling", true },
                    { -65, -12, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "DOM Manipulation", true },
                    { -64, -12, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 25, 0, 0), "Functions و Scope", true },
                    { -63, -12, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 10, 0, 0), "Variables و Data Types", true },
                    { -62, -12, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 40, 0, 0), "معرفی JavaScript و کاربردهای آن", true },
                    { -61, -11, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "Flexbox و Grid Layout", true },
                    { -60, -11, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "CSS3 Fundamentals و Styling", true },
                    { -59, -11, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 15, 0, 0), "آموزش HTML5 Semantics", true },
                    { -58, -11, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 45, 0, 0), "معرفی HTML و ساختار صفحات وب", true },
                    { -57, -10, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Design Systems در Figma", false },
                    { -56, -10, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 40, 0, 0), "Wireframing و Prototyping", false },
                    { -55, -10, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 20, 0, 0), "اصول Design و User Research", false },
                    { -54, -10, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 35, 0, 0), "معرفی Figma و محیط کار", true },
                    { -53, -9, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "Container Orchestration", false },
                    { -52, -9, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Docker Compose و Multi-Container Apps", false },
                    { -51, -9, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Docker Fundamentals و Basic Commands", false },
                    { -50, -9, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 50, 0, 0), "معرفی Docker و Containerization", true },
                    { -49, -8, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 25, 0, 0), "Indexing و Performance", false },
                    { -48, -8, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 10, 0, 0), "Aggregation Framework", false },
                    { -47, -8, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 35, 0, 0), "CRUD Operations در MongoDB", false },
                    { -46, -8, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 40, 0, 0), "معرفی MongoDB و NoSQL", true },
                    { -45, -7, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 50, 0, 0), "Indexing و Performance Tuning", false },
                    { -44, -7, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Stored Procedures و Functions", false },
                    { -43, -7, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "JOINها و روابط بین جداول", false },
                    { -42, -7, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "آموزش SELECT و Query نویسی", false },
                    { -41, -7, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 45, 0, 0), "معرفی SQL Server و نصب", true },
                    { -40, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 40, 0, 0), "کار با Native Modules", false },
                    { -39, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "State Management در React Native", false },
                    { -38, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Navigation بین صفحات", false },
                    { -37, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Styling و Layout در React Native", false },
                    { -36, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 20, 0, 0), "Components و JSX در React Native", false },
                    { -35, -6, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 50, 0, 0), "معرفی React Native و محیط توسعه", true },
                    { -34, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 35, 0, 0), "Networking و API Calls", false },
                    { -33, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 50, 0, 0), "کار با Room Database", false },
                    { -32, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 15, 0, 0), "Android Jetpack Components", false },
                    { -31, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Layoutها و UI Design", false },
                    { -30, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 40, 0, 0), "Activity و Fragment", false },
                    { -29, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "آموزش Kotlin Fundamentals", false },
                    { -28, -5, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 55, 0, 0), "معرفی Android Studio و Kotlin", true },
                    { -27, -4, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Integration با React", false },
                    { -26, -4, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Generics در TypeScript", false },
                    { -25, -4, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 25, 0, 0), "Interfaces و Custom Types", false },
                    { -24, -4, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 10, 0, 0), "Types و Type Annotations", false },
                    { -23, -4, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 40, 0, 0), "معرفی TypeScript و مزایای آن", true },
                    { -22, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "آموزش Redux برای State Management پیشرفته", false },
                    { -21, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "State Management با Context API", false },
                    { -20, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 15, 0, 0), "Routing با React Router", false },
                    { -19, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Hooks - useState و useEffect", false },
                    { -18, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 35, 0, 0), "State و Props", false },
                    { -17, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 20, 0, 0), "Components و JSX", false },
                    { -16, -3, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 0, 0, 0), "آشنایی با React و مفاهیم پایه", true },
                    { -15, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Caching و Performance", false },
                    { -14, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "امنیت با JWT و OAuth2", false },
                    { -13, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 45, 0, 0), "Documentation با Swagger", false },
                    { -12, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 15, 0, 0), "Versioning در Web API", false },
                    { -11, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 25, 0, 0), "طراحی Endpointهای حرفه‌ای", false },
                    { -10, -2, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 50, 0, 0), "مقدمه‌ای بر RESTful API", true },
                    { -9, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 10, 0, 0), "Deployment و DevOps", true },
                    { -8, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 20, 0, 0), "تست نویسی و Unit Testing", false },
                    { -7, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "SignalR و برنامه‌های Real-time", false },
                    { -6, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 15, 0, 0), "سیستم احراز هویت با Identity", false },
                    { -5, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 45, 0, 0), "Entity Framework Core و Database First", false },
                    { -4, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 2, 0, 0, 0), "آموزش کامل MVC Pattern", false },
                    { -3, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 30, 0, 0), "Routing و Middleware در ASP.NET Core", false },
                    { -2, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 1, 15, 0, 0), "آشنایی با معماری ASP.NET Core", false },
                    { -1, -1, "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip", new TimeSpan(0, 0, 45, 0, 0), "معرفی دوره و نصب پیش‌نیازها", true }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RP_Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { -21, -43, -2 },
                    { -20, -42, -2 },
                    { -19, -41, -2 },
                    { -17, -53, -1 },
                    { -16, -52, -1 },
                    { -15, -51, -1 },
                    { -14, -43, -1 },
                    { -13, -42, -1 },
                    { -12, -41, -1 },
                    { -11, -33, -1 },
                    { -10, -32, -1 },
                    { -9, -31, -1 },
                    { -8, -23, -1 },
                    { -7, -22, -1 },
                    { -6, -21, -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // 1️⃣ حذف RolePermission‌ ها (بیشترین وابستگی)
            migrationBuilder.DeleteData(table: "RolePermission", keyColumn: "RP_Id", keyValues: new object[]
            {
        -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1
            });

            // 2️⃣ حذف UserRoles
            migrationBuilder.DeleteData(table: "UserRoles", keyColumn: "UR_Id", keyValues: new object[]
            {
        -5, -4, -3, -2, -1
            });

            // 3️⃣ حذف CourseEpisodes (فرزند Courses)
            migrationBuilder.DeleteData(table: "CourseEpisodes", keyColumn: "EpisodeId", keyValues: Enumerable.Range(-66, 66).Select(i => (object)i).ToArray());

            // 4️⃣ حذف Courses
            migrationBuilder.DeleteData(table: "Courses", keyColumn: "CourseId", keyValues: Enumerable.Range(-12, 12).Select(i => (object)i).ToArray());

            // 5️⃣ حذف Permission‌ها (همه سطوح)
            migrationBuilder.DeleteData(table: "Permission", keyColumn: "PermissionId", keyValues: new object[]
            {
        -53, -52, -51,
        -43, -42, -41,
        -33, -32, -31,
        -23, -22, -21,
        -5, -4, -3, -2, -1
            });

            // 6️⃣ حذف CourseGroups (اول زیرگروه‌ها، بعد والدها)
            migrationBuilder.DeleteData(table: "CourseGroups", keyColumn: "GroupId", keyValues: new object[]
            {
        // زیرگروه‌ها
        -708, -707, -706, -705, -704, -703, -702, -701,
        -608, -607, -606, -605, -604, -603, -602, -601,
        -509, -508, -507, -506, -505, -504, -503, -502, -501,
        -409, -408, -407, -406, -405, -404, -403, -402, -401,
        -306, -305, -304, -303, -302, -301,
        -208, -207, -206, -205, -204, -203, -202, -201,
        -108, -107, -106, -105, -104, -103, -102, -101,
        // والدها
        -7, -6, -5, -4, -3, -2, -1
            });

            // 7️⃣ حذف Users
            migrationBuilder.DeleteData(table: "Users", keyColumn: "UserId", keyValues: new object[]
            {
        -4, -3, -2, -1
            });

            // 8️⃣ حذف Roles
            migrationBuilder.DeleteData(table: "Roles", keyColumn: "RoleId", keyValues: new object[]
            {
        -3, -2, -1
            });

            // 9️⃣ حذف WalletTypes
            migrationBuilder.DeleteData(table: "WalletTypes", keyColumn: "TypeId", keyValues: new object[]
            {
        -2, -1
            });

            // 🔟 حذف CourseLevels
            migrationBuilder.DeleteData(table: "CourseLevels", keyColumn: "LevelId", keyValues: new object[]
            {
        -4, -3, -2, -1
            });

            // 1️⃣1️⃣ حذف CourseStatuses
            migrationBuilder.DeleteData(table: "CourseStatuses", keyColumn: "StatusId", keyValues: new object[]
            {
        -2, -1
            });
        }
    }
}
