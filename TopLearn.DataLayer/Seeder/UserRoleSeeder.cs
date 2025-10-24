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
    public class UserRoleSeeder : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder.HasData(
                  new UserRole { UR_Id = -1, RoleId = -1, UserId = -1 },
                  new UserRole { UR_Id = -2, RoleId = -2, UserId = -1 },
                  new UserRole { UR_Id = -3, RoleId = -2, UserId = -2 },
                  new UserRole { UR_Id = -4, RoleId = -2, UserId = -3 },
                  new UserRole { UR_Id = -5, RoleId = -2, UserId = -4 }
              );
        }
    }
}
