using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.DataLayer.Seeder
{
    public class CourseSeeder : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            var createDate = new DateTime(2020, 01, 01);

            builder.HasData(
            #region دوره‌های ASP.NET Core
                new Course
                {
                    CourseId = -1,
                    GroupId = -2, // ASP.NET Core
                    SubGroup = -201, // ASP.NET Core MVC
                    TeacherId = -2, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -2, // متوسط
                    CourseTitle = "آموزش کامل ASP.NET Core 9 - از صفر تا صد",
                    CourseDescription = @"در این دوره جامع، شما با فریمورک قدرتمند ASP.NET Core 9 آشنا خواهید شد. از مباحث پایه مانند Routing و Middleware تا مباحث پیشرفته مانند CQRS Pattern، Clean Architecture و Microservices.
                     مباحث اصلی دوره :   
                    - اصول پایه ASP.NET Core 9
                    - معماری MVC و Web API
                    - Entity Framework Core 9
                    - Identity و سیستم احراز هویت
                    - SignalR برای برنامه‌های Real-time
                    - تست نویسی (Unit Test & Integration Test)
                    - DevOps

این دوره مناسب توسعه‌دهندگان .NET است که می‌خواهند به صورت حرفه‌ای با ASP.NET Core کار کنند.",
                    CoursePrice = 850000,
                    Tags = "ASP.NET Core,Web Development,C#,MVC,Web API,Entity Framework",
                    CourseImageName = "24af9d08a5fe440a8d49840afa9ed208.jpg",
                    DemoFileName = "aspnet-core-demo.mp4",
                    CreateDate = createDate,
                    UpdateDate = null
                },
                new Course
                {
                    CourseId = -2,
                    GroupId = -2, // ASP.NET Core
                    SubGroup = -201, // ASP.NET Core Web API
                    TeacherId = -3, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -3, // پیشرفته
                    CourseTitle = "آموزش پیشرفته Web API در ASP.NET Core",
                    CourseDescription = @"در این دوره پیشرفته، شما یاد خواهید گرفت چگونه APIهای RESTful حرفه‌ای با ASP.NET Core بسازید.

سرفصل‌های دوره:
- طراحی RESTful API
- Versioning در Web API
- Documentation با Swagger/OpenAPI
- Caching و Performance Optimization
- Security (JWT, OAuth2)
- Rate Limiting
- Background Services
- Integration Testing",
                    CoursePrice = 650000,
                    Tags = "ASP.NET Core,Web API,RESTful,JWT,Swagger,Performance",
                    CourseImageName = "2030ac10cf1e4679b8d0e0c9d7751fe1.jpg",
                    DemoFileName = "web-api-demo.mp4",
                    CreateDate = createDate.AddDays(-15),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های Frontend
                new Course
                {
                    CourseId = -3,
                    GroupId = -2, // Frontend Development
                    SubGroup = -207, // React.js
                    TeacherId = -4, // teacher1
                    StatusId = -2, // تکمیل شده
                    LevelId = -2, // متوسط
                    CourseTitle = "آموزش React.js - توسعه رابط کاربری مدرن",
                    CourseDescription = @"یادگیری React.js به همراه پروژه‌های عملی و واقعی. از مفاهیم پایه تا hooks پیشرفته.

مباحث covered:
- Components و JSX
- State و Props
- Hooks (useState, useEffect, useContext)
- Routing با React Router
- State Management با Context API و Redux
- Testing با Jest
- Deployment",
                    CoursePrice = 550000,
                    Tags = "React.js,JavaScript,Frontend,Hooks,Redux",
                    CourseImageName = "2db60db10ed347b590d08719ce6f5668.jpg",
                    DemoFileName = "react-demo.mp4",
                    CreateDate = createDate.AddDays(-30),
                    UpdateDate = null
                },
                new Course
                {
                    CourseId = -4,
                    GroupId = -2, // Frontend Development
                    SubGroup = -207, // TypeScript
                    TeacherId = -2, // teacher1
                    StatusId = -1, // در حال برگزاری
                    LevelId = -2, // متوسط
                    CourseTitle = "آموزش TypeScript برای توسعه‌دهندگان JavaScript",
                    CourseDescription = @"TypeScript زبان برنامه‌نویسی مدرن که توسعه JavaScript را متحول کرده است.

سرفصل‌ها:
- Types و Interfaces
- Generics
- Decorators
- Integration با React و Angular
- Advanced Types
- Project Configuration",
                    CoursePrice = 450000,
                    Tags = "TypeScript,JavaScript,Frontend,Programming",
                    CourseImageName = "e06bfeed4f8d40e99a1804bd0fae60d7.jpg",
                    DemoFileName = "typescript-demo.mp4",
                    CreateDate = createDate.AddDays(-10),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های Mobile
                new Course
                {
                    CourseId = -5,
                    GroupId = -1, // Android
                    SubGroup = -101, // Android Jetpack
                    TeacherId = -2, // teacher1
                    StatusId = -2, // تکمیل شده
                    LevelId = -2, // متوسط
                    CourseTitle = "آموزش توسعه اپلیکیشن Android با Kotlin",
                    CourseDescription = @"توسعه اپلیکیشن‌های مدرن Android با Kotlin و Android Jetpack.

مباحث اصلی:
- Kotlin Fundamentals
- Android Jetpack Components
- Room Database
- WorkManager
- Navigation Component
- Testing",
                    CoursePrice = 750000,
                    Tags = "Android,Kotlin,Mobile Development,Jetpack",
                    CourseImageName = "38b32431b36d4833b65eeefaa9e50f21.jpg",
                    DemoFileName = "android-demo.mp4",
                    CreateDate = createDate.AddDays(-45),
                    UpdateDate = null
                },
                new Course
                {
                    CourseId = -6,
                    GroupId = -1, // React Native
                    SubGroup = -103, // React Native Advanced
                    TeacherId = -3, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -3, // پیشرفته
                    CourseTitle = "توسعه اپلیکیشن‌های Cross-Platform با React Native",
                    CourseDescription = @"یادگیری توسعه اپلیکیشن‌های موبایل برای iOS و Android با React Native.

سرفصل‌ها:
- React Native Fundamentals
- Navigation
- State Management
- Native Modules
- Performance Optimization
- Publishing to Stores",
                    CoursePrice = 680000,
                    Tags = "React Native,Mobile,Cross-Platform,JavaScript",
                    CourseImageName = "9ec1c01ac39548aebfc4dce97c08bb74.jpg",
                    DemoFileName = "react-native-demo.mp4",
                    CreateDate = createDate.AddDays(-25),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های Database
                new Course
                {
                    CourseId = -7,
                    GroupId = -5, // SQL Server
                    SubGroup = -501, // T-SQL Programming
                    TeacherId = -4, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -2, // متوسط
                    CourseTitle = "آموزش جامع SQL Server و T-SQL",
                    CourseDescription = @"مهارت‌های ضروری برای کار با SQL Server و نوشتن Queryهای بهینه.

مباحث covered:
- Database Design
- T-SQL Programming
- Stored Procedures و Functions
- Indexing و Performance Tuning
- Security و Permissions
- Backup و Recovery",
                    CoursePrice = 480000,
                    Tags = "SQL Server,Database,T-SQL,SQL,Performance",
                    CourseImageName = "dc8910af08ab41e0b69a1ef9e5b6b5c4.jpg",
                    DemoFileName = "sql-server-demo.mp4",
                    CreateDate = createDate.AddDays(-40),
                    UpdateDate = null
                },
                new Course
                {
                    CourseId = -8,
                    GroupId = -5, // MongoDB
                    SubGroup = -505, // MongoDB Aggregation
                    TeacherId = -2, // teacher1
                    StatusId = -1, // در حال برگزاری
                    LevelId = -3, // پیشرفته
                    CourseTitle = "آموزش MongoDB - پایگاه داده NoSQL",
                    CourseDescription = @"یادگیری کار با MongoDB برای برنامه‌های مدرن.

سرفصل‌ها:
- MongoDB Fundamentals
- CRUD Operations
- Aggregation Framework
- Indexing
- Replication و Sharding
- Integration با .NET",
                    CoursePrice = 520000,
                    Tags = "MongoDB,NoSQL,Database,Aggregation",
                    CourseImageName = "7c394f471bae4a52a6fc1f66bd8e9da1.jpg",
                    DemoFileName = "mongodb-demo.mp4",
                    CreateDate = createDate.AddDays(-5),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های DevOps
                new Course
                {
                    CourseId = -9,
                    GroupId = -7, // Docker
                    SubGroup = -705, // Docker Compose
                    TeacherId = -2, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -3, // پیشرفته
                    CourseTitle = "آموزش Docker و Containerization",
                    CourseDescription = @"مدیریت برنامه‌ها با Docker و Kubernetes.

مباحث اصلی:
- Docker Fundamentals
- Docker Compose
- Container Orchestration
- CI/CD Pipelines
- Monitoring و Logging",
                    CoursePrice = 600000,
                    Tags = "Docker,Container,DevOps,Kubernetes,CI/CD",
                    CourseImageName = "8a29ceb69d0d445fa5a84a23f8289fc1.jpg",
                    DemoFileName = "docker-demo.mp4",
                    CreateDate = createDate.AddDays(-20),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های طراحی
                new Course
                {
                    CourseId = -10,
                    GroupId = -4, // UI/UX Design
                    SubGroup = -407, // User Research
                    TeacherId = -2, // teacher1
                    StatusId = -2, // تکمیل شده
                    LevelId = -1, // مقدماتی
                    CourseTitle = "آموزش طراحی UI/UX با Figma",
                    CourseDescription = @"یادگیری اصول طراحی رابط کاربری و تجربه کاربری با Figma.

سرفصل‌ها:
- Design Principles
- User Research
- Wireframing
- Prototyping
- Design Systems
- Collaboration در Figma",
                    CoursePrice = 380000,
                    Tags = "UI/UX,Figma,Design,User Research",
                    CourseImageName = "cc2e5dd085224351a743992ed58d6f5f.jpg",
                    DemoFileName = "figma-demo.mp4",
                    CreateDate = createDate.AddDays(-35),
                    UpdateDate = null
                },
            #endregion

            #region دوره‌های رایگان
                new Course
                {
                    CourseId = -11,
                    GroupId = -4, // HTML & CSS
                    SubGroup = -401,
                    TeacherId = -3, // teacher1
                    StatusId = -2, // تکمیل شده
                    LevelId = -1, // مقدماتی
                    CourseTitle = "آموزش رایگان HTML و CSS - مقدماتی",
                    CourseDescription = @"دوره رایگان برای شروع یادگیری طراحی وب با HTML و CSS.

مباحث covered:
- HTML5 Semantics
- CSS3 Fundamentals
- Flexbox و Grid
- Responsive Design
- CSS Animations",
                    CoursePrice = 0,
                    Tags = "HTML,CSS,Frontend,Free Course",
                    CourseImageName = "df04d23e71d5483fb0b33bb8ca3e0036.jpg",
                    DemoFileName = "html-css-demo.mp4",
                    CreateDate = createDate.AddDays(-60),
                    UpdateDate = null
                },
                new Course
                {
                    CourseId = -12,
                    GroupId = -4, // JavaScript
                    SubGroup = -402,
                    TeacherId = -4, // Administrator
                    StatusId = -2, // تکمیل شده
                    LevelId = -1, // مقدماتی
                    CourseTitle = "آموزش JavaScript برای مبتدیان",
                    CourseDescription = @"یادگیری اصول برنامه‌نویسی با JavaScript.

سرفصل‌ها:
- Variables و Data Types
- Functions
- DOM Manipulation
- Events
- ES6+ Features",
                    CoursePrice = 0,
                    Tags = "JavaScript,Programming,Free Course,Beginners",
                    CourseImageName = "cbfb83419c7f489a93a18072a42b16c4.jpg",
                    DemoFileName = "javascript-demo.mp4",
                    CreateDate = createDate.AddDays(-50),
                    UpdateDate = null
                }
                #endregion
            );
        }
    }
}