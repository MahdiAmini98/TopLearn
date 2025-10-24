using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.DataLayer.Seeder
{
    public class UserSeeder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
              new User
              {
                  UserId = -1,
                  UserName = "Administrator",
                  Email = "Admin@Gmail.com",
                  Password = "26-DC-31-89-42-68-58-72-CF-79-C5-EB-96-C9-BB-13", //--> Admin@12345
                  ActiveCode = "AdministratorActiveCode",
                  IsActive = true,
                  UserAvatar = "427b6fa79ef542f2956586ec88990c8d.jpg",
                  RegisterDate = new DateTime(2020, 01, 01),
                  IsDelete = false
              },
              new User
              {
                  UserId = -2,
                  UserName = "مهدی امینی",
                  Email = "MahdiAmini@Gmail.com",
                  Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", //--> 123
                  ActiveCode = "MahdiAminiActiveCode",
                  IsActive = true,
                  UserAvatar = "ed75d864648641f3b5440d43447470bc.jpg",
                  RegisterDate = new DateTime(2020, 01, 01),
                  IsDelete = false
              },
               new User
               {
                   UserId = -3,
                   UserName = "نازنین سهروردی",
                   Email = "Nazanin@Gmail.com",
                   Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", //--> 123
                   ActiveCode = "NazaninActiveCode",
                   IsActive = true,
                   UserAvatar = "46895918151d44069832d66cbb880534.jpg",
                   RegisterDate = new DateTime(2020, 01, 01),
                   IsDelete = false
               },
               new User
               {
                   UserId = -4,
                   UserName = "رضا جویباری",
                   Email = "Reza@Gmail.com",
                   Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", //--> 123
                   ActiveCode = "RezaActiveCode",
                   IsActive = true,
                   UserAvatar = "c5c426500629418a8093b899d2deaced.jpg",
                   RegisterDate = new DateTime(2020, 01, 01),
                   IsDelete = false
               }
          );
        }
    }
}
