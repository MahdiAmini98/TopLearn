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
    public class CourseStatusSeeder : IEntityTypeConfiguration<CourseStatus>
    {
        public void Configure(EntityTypeBuilder<CourseStatus> builder)
        {
            builder.HasData(
                new CourseStatus { StatusId = -1, StatusTitle = "دوره در حال برگزاری است" },
                new CourseStatus { StatusId = -2, StatusTitle = "دوره به اتمام رسیده است" }
            );
        }
    }
}
