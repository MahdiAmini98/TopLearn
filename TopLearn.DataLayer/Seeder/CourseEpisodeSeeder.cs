using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.DataLayer.Seeder
{
    public class CourseEpisodeSeeder : IEntityTypeConfiguration<CourseEpisode>
    {
        public void Configure(EntityTypeBuilder<CourseEpisode> builder)
        {
            builder.HasData(
            #region دوره ASP.NET Core 9 (CourseId = -1)
                new CourseEpisode
                {
                    EpisodeId = -1,
                    CourseId = -1,
                    EpisodeTitle = "معرفی دوره و نصب پیش‌نیازها",
                    EpisodeTime = new TimeSpan(0, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -2,
                    CourseId = -1,
                    EpisodeTitle = "آشنایی با معماری ASP.NET Core",
                    EpisodeTime = new TimeSpan(1, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -3,
                    CourseId = -1,
                    EpisodeTitle = "Routing و Middleware در ASP.NET Core",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -4,
                    CourseId = -1,
                    EpisodeTitle = "آموزش کامل MVC Pattern",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -5,
                    CourseId = -1,
                    EpisodeTitle = "Entity Framework Core و Database First",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -6,
                    CourseId = -1,
                    EpisodeTitle = "سیستم احراز هویت با Identity",
                    EpisodeTime = new TimeSpan(2, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -7,
                    CourseId = -1,
                    EpisodeTitle = "SignalR و برنامه‌های Real-time",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -8,
                    CourseId = -1,
                    EpisodeTitle = "تست نویسی و Unit Testing",
                    EpisodeTime = new TimeSpan(1, 20, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -9,
                    CourseId = -1,
                    EpisodeTitle = "Deployment و DevOps",
                    EpisodeTime = new TimeSpan(1, 10, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
            #endregion

            #region دوره Web API (CourseId = -2)
                new CourseEpisode
                {
                    EpisodeId = -10,
                    CourseId = -2,
                    EpisodeTitle = "مقدمه‌ای بر RESTful API",
                    EpisodeTime = new TimeSpan(0, 50, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -11,
                    CourseId = -2,
                    EpisodeTitle = "طراحی Endpointهای حرفه‌ای",
                    EpisodeTime = new TimeSpan(1, 25, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -12,
                    CourseId = -2,
                    EpisodeTitle = "Versioning در Web API",
                    EpisodeTime = new TimeSpan(1, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -13,
                    CourseId = -2,
                    EpisodeTitle = "Documentation با Swagger",
                    EpisodeTime = new TimeSpan(0, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -14,
                    CourseId = -2,
                    EpisodeTitle = "امنیت با JWT و OAuth2",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -15,
                    CourseId = -2,
                    EpisodeTitle = "Caching و Performance",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره React.js (CourseId = -3)
                new CourseEpisode
                {
                    EpisodeId = -16,
                    CourseId = -3,
                    EpisodeTitle = "آشنایی با React و مفاهیم پایه",
                    EpisodeTime = new TimeSpan(1, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -17,
                    CourseId = -3,
                    EpisodeTitle = "Components و JSX",
                    EpisodeTime = new TimeSpan(1, 20, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -18,
                    CourseId = -3,
                    EpisodeTitle = "State و Props",
                    EpisodeTime = new TimeSpan(1, 35, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -19,
                    CourseId = -3,
                    EpisodeTitle = "Hooks - useState و useEffect",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -20,
                    CourseId = -3,
                    EpisodeTitle = "Routing با React Router",
                    EpisodeTime = new TimeSpan(1, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -21,
                    CourseId = -3,
                    EpisodeTitle = "State Management با Context API",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -22,
                    CourseId = -3,
                    EpisodeTitle = "آموزش Redux برای State Management پیشرفته",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره TypeScript (CourseId = -4)
                new CourseEpisode
                {
                    EpisodeId = -23,
                    CourseId = -4,
                    EpisodeTitle = "معرفی TypeScript و مزایای آن",
                    EpisodeTime = new TimeSpan(0, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -24,
                    CourseId = -4,
                    EpisodeTitle = "Types و Type Annotations",
                    EpisodeTime = new TimeSpan(1, 10, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -25,
                    CourseId = -4,
                    EpisodeTitle = "Interfaces و Custom Types",
                    EpisodeTime = new TimeSpan(1, 25, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -26,
                    CourseId = -4,
                    EpisodeTitle = "Generics در TypeScript",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -27,
                    CourseId = -4,
                    EpisodeTitle = "Integration با React",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره Android با Kotlin (CourseId = -5)
                new CourseEpisode
                {
                    EpisodeId = -28,
                    CourseId = -5,
                    EpisodeTitle = "معرفی Android Studio و Kotlin",
                    EpisodeTime = new TimeSpan(0, 55, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -29,
                    CourseId = -5,
                    EpisodeTitle = "آموزش Kotlin Fundamentals",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -30,
                    CourseId = -5,
                    EpisodeTitle = "Activity و Fragment",
                    EpisodeTime = new TimeSpan(1, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -31,
                    CourseId = -5,
                    EpisodeTitle = "Layoutها و UI Design",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -32,
                    CourseId = -5,
                    EpisodeTitle = "Android Jetpack Components",
                    EpisodeTime = new TimeSpan(2, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -33,
                    CourseId = -5,
                    EpisodeTitle = "کار با Room Database",
                    EpisodeTime = new TimeSpan(1, 50, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -34,
                    CourseId = -5,
                    EpisodeTitle = "Networking و API Calls",
                    EpisodeTime = new TimeSpan(1, 35, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره React Native (CourseId = -6)
                new CourseEpisode
                {
                    EpisodeId = -35,
                    CourseId = -6,
                    EpisodeTitle = "معرفی React Native و محیط توسعه",
                    EpisodeTime = new TimeSpan(0, 50, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -36,
                    CourseId = -6,
                    EpisodeTitle = "Components و JSX در React Native",
                    EpisodeTime = new TimeSpan(1, 20, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -37,
                    CourseId = -6,
                    EpisodeTitle = "Styling و Layout در React Native",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -38,
                    CourseId = -6,
                    EpisodeTitle = "Navigation بین صفحات",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -39,
                    CourseId = -6,
                    EpisodeTitle = "State Management در React Native",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -40,
                    CourseId = -6,
                    EpisodeTitle = "کار با Native Modules",
                    EpisodeTime = new TimeSpan(1, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره SQL Server (CourseId = -7)
                new CourseEpisode
                {
                    EpisodeId = -41,
                    CourseId = -7,
                    EpisodeTitle = "معرفی SQL Server و نصب",
                    EpisodeTime = new TimeSpan(0, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -42,
                    CourseId = -7,
                    EpisodeTitle = "آموزش SELECT و Query نویسی",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -43,
                    CourseId = -7,
                    EpisodeTitle = "JOINها و روابط بین جداول",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -44,
                    CourseId = -7,
                    EpisodeTitle = "Stored Procedures و Functions",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -45,
                    CourseId = -7,
                    EpisodeTitle = "Indexing و Performance Tuning",
                    EpisodeTime = new TimeSpan(1, 50, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره MongoDB (CourseId = -8)
                new CourseEpisode
                {
                    EpisodeId = -46,
                    CourseId = -8,
                    EpisodeTitle = "معرفی MongoDB و NoSQL",
                    EpisodeTime = new TimeSpan(0, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -47,
                    CourseId = -8,
                    EpisodeTitle = "CRUD Operations در MongoDB",
                    EpisodeTime = new TimeSpan(1, 35, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -48,
                    CourseId = -8,
                    EpisodeTitle = "Aggregation Framework",
                    EpisodeTime = new TimeSpan(2, 10, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -49,
                    CourseId = -8,
                    EpisodeTitle = "Indexing و Performance",
                    EpisodeTime = new TimeSpan(1, 25, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره Docker (CourseId = -9)
                new CourseEpisode
                {
                    EpisodeId = -50,
                    CourseId = -9,
                    EpisodeTitle = "معرفی Docker و Containerization",
                    EpisodeTime = new TimeSpan(0, 50, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -51,
                    CourseId = -9,
                    EpisodeTitle = "Docker Fundamentals و Basic Commands",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -52,
                    CourseId = -9,
                    EpisodeTitle = "Docker Compose و Multi-Container Apps",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -53,
                    CourseId = -9,
                    EpisodeTitle = "Container Orchestration",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره UI/UX با Figma (CourseId = -10)
                new CourseEpisode
                {
                    EpisodeId = -54,
                    CourseId = -10,
                    EpisodeTitle = "معرفی Figma و محیط کار",
                    EpisodeTime = new TimeSpan(0, 35, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -55,
                    CourseId = -10,
                    EpisodeTitle = "اصول Design و User Research",
                    EpisodeTime = new TimeSpan(1, 20, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -56,
                    CourseId = -10,
                    EpisodeTitle = "Wireframing و Prototyping",
                    EpisodeTime = new TimeSpan(1, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
                new CourseEpisode
                {
                    EpisodeId = -57,
                    CourseId = -10,
                    EpisodeTitle = "Design Systems در Figma",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = false
                },
            #endregion

            #region دوره HTML/CSS رایگان (CourseId = -11)
                new CourseEpisode
                {
                    EpisodeId = -58,
                    CourseId = -11,
                    EpisodeTitle = "معرفی HTML و ساختار صفحات وب",
                    EpisodeTime = new TimeSpan(0, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -59,
                    CourseId = -11,
                    EpisodeTitle = "آموزش HTML5 Semantics",
                    EpisodeTime = new TimeSpan(1, 15, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -60,
                    CourseId = -11,
                    EpisodeTitle = "CSS3 Fundamentals و Styling",
                    EpisodeTime = new TimeSpan(1, 30, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -61,
                    CourseId = -11,
                    EpisodeTitle = "Flexbox و Grid Layout",
                    EpisodeTime = new TimeSpan(2, 0, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
            #endregion

            #region دوره JavaScript رایگان (CourseId = -12)
                new CourseEpisode
                {
                    EpisodeId = -62,
                    CourseId = -12,
                    EpisodeTitle = "معرفی JavaScript و کاربردهای آن",
                    EpisodeTime = new TimeSpan(0, 40, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -63,
                    CourseId = -12,
                    EpisodeTitle = "Variables و Data Types",
                    EpisodeTime = new TimeSpan(1, 10, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -64,
                    CourseId = -12,
                    EpisodeTitle = "Functions و Scope",
                    EpisodeTime = new TimeSpan(1, 25, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -65,
                    CourseId = -12,
                    EpisodeTitle = "DOM Manipulation",
                    EpisodeTime = new TimeSpan(1, 45, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                },
                new CourseEpisode
                {
                    EpisodeId = -66,
                    CourseId = -12,
                    EpisodeTitle = "Events و Event Handling",
                    EpisodeTime = new TimeSpan(1, 20, 0),
                    EpisodeFileName = "b18e2bb8068dd9bc9881b6eacd7eba0421611010-360p.zip",
                    IsFree = true
                }
                #endregion
            );
        }
    }
}