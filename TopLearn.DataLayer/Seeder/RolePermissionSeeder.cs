using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.DataLayer.Entities.Permissions;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.DataLayer.Seeder
{
    public class RolePermissionSeeder : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasData(
                 //Admin Role Permission
                 new RolePermission { RP_Id = -1, RoleId = -1, PermissionId = -1 },
                 new RolePermission { RP_Id = -2, RoleId = -1, PermissionId = -2 },
                 new RolePermission { RP_Id = -3, RoleId = -1, PermissionId = -3 },
                 new RolePermission { RP_Id = -4, RoleId = -1, PermissionId = -4 },
                 new RolePermission { RP_Id = -5, RoleId = -1, PermissionId = -5 },
                 new RolePermission { RP_Id = -6, RoleId = -1, PermissionId = -21 },
                 new RolePermission { RP_Id = -7, RoleId = -1, PermissionId = -22 },
                 new RolePermission { RP_Id = -8, RoleId = -1, PermissionId = -23 },
                 new RolePermission { RP_Id = -9, RoleId = -1, PermissionId = -31 },
                 new RolePermission { RP_Id = -10, RoleId = -1, PermissionId = -32 },
                 new RolePermission { RP_Id = -11, RoleId = -1, PermissionId = -33 },
                 new RolePermission { RP_Id = -12, RoleId = -1, PermissionId = -41 },
                 new RolePermission { RP_Id = -13, RoleId = -1, PermissionId = -42 },
                 new RolePermission { RP_Id = -14, RoleId = -1, PermissionId = -43 },
                 new RolePermission { RP_Id = -15, RoleId = -1, PermissionId = -51 },
                 new RolePermission { RP_Id = -16, RoleId = -1, PermissionId = -52 },
                 new RolePermission { RP_Id = -17, RoleId = -1, PermissionId = -53 },

                 //Teacher Role Permission
                 new RolePermission { RP_Id = -18, RoleId = -2, PermissionId = -4 },
                 new RolePermission { RP_Id = -19, RoleId = -2, PermissionId = -41 },
                 new RolePermission { RP_Id = -20, RoleId = -2, PermissionId = -42 },
                 new RolePermission { RP_Id = -21, RoleId = -2, PermissionId = -43 }
             );
        }
    }
}
