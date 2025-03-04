using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasData(
                new Cart
                {
                    Id = new Guid("75966b29-8f9f-49c6-b366-42c245696a2f"),
                    UserID = new Guid("bfa4ee73-f13b-487c-8fd4-0e074725d2dd"),
                    Email = "quocthangjk@gmail.com",
                }


                );
        }
    }
}
