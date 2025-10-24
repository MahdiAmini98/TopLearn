using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.DataLayer.Seeder
{
    public class CourseGroupSeeder : IEntityTypeConfiguration<CourseGroup>
    {
        public void Configure(EntityTypeBuilder<CourseGroup> builder)
        {
            builder.HasData(
                // گروه‌های اصلی
                new CourseGroup { GroupId = -1, GroupTitle = "برنامه نویسی موبایل", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -2, GroupTitle = "برنامه‌نویسی وب", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -3, GroupTitle = "برنامه نویسی تحت ویندوز", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -4, GroupTitle = "طراحی سایت", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -5, GroupTitle = "بانک های اطلاعاتی", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -6, GroupTitle = "سئو", IsDelete = false, ParentId = null },
                new CourseGroup { GroupId = -7, GroupTitle = "سیستم عامل", IsDelete = false, ParentId = null },


            #region زیرگروه‌های برنامه نویسی موبایل (GroupId = -1)
                new CourseGroup { GroupId = -101, GroupTitle = "اندروید (Android)", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -102, GroupTitle = "iOS", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -103, GroupTitle = "React Native", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -104, GroupTitle = "Flutter", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -105, GroupTitle = "Xamarin", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -106, GroupTitle = "Ionic", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -107, GroupTitle = "Kotlin", IsDelete = false, ParentId = -1 },
                new CourseGroup { GroupId = -108, GroupTitle = "Swift", IsDelete = false, ParentId = -1 },
            #endregion

            #region زیرگروه‌های برنامه‌نویسی وب (GroupId = -2)
                new CourseGroup { GroupId = -201, GroupTitle = "ASP.NET Core", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -202, GroupTitle = "PHP Laravel", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -203, GroupTitle = "Django", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -204, GroupTitle = "Spring Boot", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -205, GroupTitle = "Node.js", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -206, GroupTitle = "Ruby on Rails", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -207, GroupTitle = "Frontend Development", IsDelete = false, ParentId = -2 },
                new CourseGroup { GroupId = -208, GroupTitle = "Full Stack Development", IsDelete = false, ParentId = -2 },
            #endregion

            #region زیرگروه‌های برنامه نویسی تحت ویندوز (GroupId = -3)
                new CourseGroup { GroupId = -301, GroupTitle = "Windows Forms", IsDelete = false, ParentId = -3 },
                new CourseGroup { GroupId = -302, GroupTitle = "WPF", IsDelete = false, ParentId = -3 },
                new CourseGroup { GroupId = -303, GroupTitle = "UWP", IsDelete = false, ParentId = -3 },
                new CourseGroup { GroupId = -304, GroupTitle = "Console Applications", IsDelete = false, ParentId = -3 },
                new CourseGroup { GroupId = -305, GroupTitle = "Windows Services", IsDelete = false, ParentId = -3 },
                new CourseGroup { GroupId = -306, GroupTitle = "WinUI", IsDelete = false, ParentId = -3 },
            #endregion

            #region زیرگروه‌های طراحی سایت (GroupId = -4)
                new CourseGroup { GroupId = -401, GroupTitle = "HTML & CSS", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -402, GroupTitle = "JavaScript", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -403, GroupTitle = "jQuery", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -404, GroupTitle = "Bootstrap", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -405, GroupTitle = "Tailwind CSS", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -406, GroupTitle = "SASS/SCSS", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -407, GroupTitle = "UI/UX Design", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -408, GroupTitle = "Figma", IsDelete = false, ParentId = -4 },
                new CourseGroup { GroupId = -409, GroupTitle = "Adobe XD", IsDelete = false, ParentId = -4 },
            #endregion

            #region زیرگروه‌های بانک های اطلاعاتی (GroupId = -5)
                new CourseGroup { GroupId = -501, GroupTitle = "SQL Server", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -502, GroupTitle = "MySQL", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -503, GroupTitle = "PostgreSQL", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -504, GroupTitle = "Oracle", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -505, GroupTitle = "MongoDB", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -506, GroupTitle = "Redis", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -507, GroupTitle = "SQLite", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -508, GroupTitle = "Database Design", IsDelete = false, ParentId = -5 },
                new CourseGroup { GroupId = -509, GroupTitle = "NoSQL Databases", IsDelete = false, ParentId = -5 },
            #endregion

            #region زیرگروه‌های سئو (GroupId = -6)
                new CourseGroup { GroupId = -601, GroupTitle = "سئو داخلی (On-Page SEO)", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -602, GroupTitle = "سئو خارجی (Off-Page SEO)", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -603, GroupTitle = "سئو تکنیکال (Technical SEO)", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -604, GroupTitle = "سئو محلی (Local SEO)", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -605, GroupTitle = "تحقیق کلمات کلیدی", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -606, GroupTitle = "آموزش Google Analytics", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -607, GroupTitle = "آموزش Google Search Console", IsDelete = false, ParentId = -6 },
                new CourseGroup { GroupId = -608, GroupTitle = "سئو اپلیکیشن", IsDelete = false, ParentId = -6 },
            #endregion

            #region زیرگروه‌های سیستم عامل (GroupId = -7)
                new CourseGroup { GroupId = -701, GroupTitle = "Windows", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -702, GroupTitle = "Linux", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -703, GroupTitle = "macOS", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -704, GroupTitle = "Virtualization", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -705, GroupTitle = "Docker", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -706, GroupTitle = "Kubernetes", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -707, GroupTitle = "Shell Scripting", IsDelete = false, ParentId = -7 },
                new CourseGroup { GroupId = -708, GroupTitle = "PowerShell", IsDelete = false, ParentId = -7 }
            #endregion
            );
        }
    }
}
