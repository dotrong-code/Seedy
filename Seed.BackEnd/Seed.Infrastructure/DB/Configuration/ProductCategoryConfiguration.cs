using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
                new ProductCategory
                {
                    Id = new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                    Name = "notebook",
                    Description = "Description",

                },
                new ProductCategory
                {
                    Id = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    Name = "postcard",
                    Description = "Description",
                },
                new ProductCategory
                {
                    Id = new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                    Name = "sticker",
                    Description = "Description",
                },

                new ProductCategory
                {
                    Id = new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                    Name = "evelope",
                    Description = "Description",
                },
                new ProductCategory
                {
                    Id = new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                    Name = "plantpot",
                    Description = "Description",
                }
                );
        }
    }
}
