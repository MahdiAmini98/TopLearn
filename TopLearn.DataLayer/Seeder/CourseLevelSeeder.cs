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
    public class CourseLevelSeeder : IEntityTypeConfiguration<CourseLevel>
    {
        public void Configure(EntityTypeBuilder<CourseLevel> builder)
        {
            builder.HasData(
               new CourseLevel { LevelId = -1, LevelTitle = "مقدماتی" },
               new CourseLevel { LevelId = -2, LevelTitle = "متوسط" },
               new CourseLevel { LevelId = -3, LevelTitle = "پیشرفته" },
               new CourseLevel { LevelId = -4, LevelTitle = "فوق پیشرفته" }
           );
        }
    }
}
