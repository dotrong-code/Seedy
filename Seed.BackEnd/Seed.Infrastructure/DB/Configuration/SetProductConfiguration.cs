using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class SetProductConfiguration : IEntityTypeConfiguration<SetProduct>
    {
        public void Configure(EntityTypeBuilder<SetProduct> builder)
        {
            builder.HasData(
                new SetProduct
                {
                    ProductId = new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                    SetId = new Guid("77be9079-5750-488b-9831-d637d2383e38")
                },
                new SetProduct
                {
                    ProductId = new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                    SetId = new Guid("77be9079-5750-488b-9831-d637d2383e38")
                },
                new SetProduct
                {
                    ProductId = new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                    SetId = new Guid("77be9079-5750-488b-9831-d637d2383e38")
                },
                new SetProduct
                {
                    ProductId = new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                    SetId = new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428")
                },
                new SetProduct
                {
                    ProductId = new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                    SetId = new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428")
                },
                new SetProduct
                {
                    ProductId = new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                    SetId = new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428")
                }

                );
        }
    }
}
