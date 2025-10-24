using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.DataLayer.Entities.Permissions;

namespace TopLearn.DataLayer.Seeder
{
    public class PermissionSeeder : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(
              // دسترسی‌های اصلی
              new Permission { PermissionId = -1, PermissionTitle = "پنل مدیریت", ParentID = null },
              new Permission { PermissionId = -2, PermissionTitle = "مدیریت کاربران", ParentID = -1 },
              new Permission { PermissionId = -3, PermissionTitle = "مدیریت نقش ها", ParentID = -1 },
              new Permission { PermissionId = -4, PermissionTitle = "مدیریت دوره‌ها", ParentID = -1 },
              new Permission { PermissionId = -5, PermissionTitle = "مدیریت کدهای تخفیف", ParentID = -1 },

              // زیرمجموعه مدیریت کاربران
              new Permission { PermissionId = -21, PermissionTitle = "افزودن کاربران", ParentID = -2 },
              new Permission { PermissionId = -22, PermissionTitle = "ویرایش کاربران", ParentID = -2 },
              new Permission { PermissionId = -23, PermissionTitle = "حذف کاربران", ParentID = -2 },

              // زیرمجموعه مدیریت نقش ها
              new Permission { PermissionId = -31, PermissionTitle = "افزودن نقش ها", ParentID = -3 },
              new Permission { PermissionId = -32, PermissionTitle = "ویرایش نقش ها", ParentID = -3 },
              new Permission { PermissionId = -33, PermissionTitle = "حذف نقش ها", ParentID = -3 },

              // زیرمجموعه مدیریت دوره‌ها
              new Permission { PermissionId = -41, PermissionTitle = "ایجاد دوره ها", ParentID = -4 },
              new Permission { PermissionId = -42, PermissionTitle = "ویرایش دوره ها", ParentID = -4 },
              new Permission { PermissionId = -43, PermissionTitle = "حذف دوره ها", ParentID = -4 },

              // زیرمجموعه مدیریت کدهای تخفیف
              new Permission { PermissionId = -51, PermissionTitle = "ایجاد کدهای تخفیف", ParentID = -5 },
              new Permission { PermissionId = -52, PermissionTitle = "ویرایش کدهای تخفیف", ParentID = -5 },
              new Permission { PermissionId = -53, PermissionTitle = "حذف کدهای تخفیف", ParentID = -5 }
          );
        }
    }
}
