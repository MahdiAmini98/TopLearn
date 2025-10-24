using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.DataLayer.Seeder
{
    public class RoleSeeder : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                  new Role { RoleId = -1, RoleTitle = "مدیر سایت", IsDelete = false },
                  new Role { RoleId = -2, RoleTitle = "استاد", IsDelete = false },
                  new Role { RoleId = -3, RoleTitle = "کاربر عادی", IsDelete = false }
              );
        }
    }
}
