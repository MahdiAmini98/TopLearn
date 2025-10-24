using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.DataLayer.Seeder
{
    public class WalletTypeSeeder : IEntityTypeConfiguration<WalletType>
    {
        public void Configure(EntityTypeBuilder<WalletType> builder)
        {
            builder.HasData(
            new WalletType { TypeId = -1, TypeTitle = "واریز" },
            new WalletType { TypeId = -2, TypeTitle = "برداشت" }
            );
        }
    }
}
