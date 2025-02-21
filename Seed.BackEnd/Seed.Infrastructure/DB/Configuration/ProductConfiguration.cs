using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                    ProductCategoryId = new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Khởi'Notebook",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fkhoi_notebook.png?alt=media&token=175005bb-bcbd-48f0-ae3a-769fdf921249"
                },
                new Product
                {
                    Id = new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Khởi'Postcard",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fkhoi_postcard.png?alt=media&token=43542455-e49d-4d41-9e06-6b5984da3de3"
                },
                new Product
                {
                    Id = new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                    ProductCategoryId = new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Khởi'Sticker",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FSticker%2Fkhoi_sticker.png?alt=media&token=bdb15026-411e-4a69-a936-ac2d0a2c2121"
                },
                new Product
                {
                    Id = new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                    ProductCategoryId = new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Thức'Notebook",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fthuc_notebook.png?alt=media&token=05133546-cbc2-4eba-bf96-e8d3f3a653eb"
                },
                new Product
                {
                    Id = new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Thức'Postcard",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fthuc_postcard.png?alt=media&token=84ca1a60-f1d2-4b6a-946d-79977e543832"
                },
                new Product
                {
                    Id = new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                    ProductCategoryId = new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "'Thức'Sticker",
                    Description = "Description",
                    Price = 100,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FSticker%2Fthuc_sticker.png?alt=media&token=54b9284e-398d-4a45-92fe-ec0ee2cdc922"
                }


                );
        }
    }
}
