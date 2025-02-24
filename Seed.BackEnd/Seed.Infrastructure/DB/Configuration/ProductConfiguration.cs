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
                },
                new Product
                {
                    Id = new Guid("fe1430bd-1b1b-496a-8be5-0c995ff42133"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'BÀN ĂN'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fban-an_postcard_%202.png?alt=media&token=0b27e5c9-01d6-46f4-bef1-26eb9a3d4cb9"
                },
                new Product
                {
                    Id = new Guid("53f4a339-bcaf-4578-917b-658843b48e61"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'CHỞ CHE'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fcho-che_postcard.png?alt=media&token=3e9dd1df-207d-4886-8265-7cf9e2e952df"
                },
                new Product
                {
                    Id = new Guid("2ee59d22-7217-4b6e-b7b3-1768b97f6532"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'CHỦ BÀI'(HỒNG)",
                    Description = "Description",
                    Price = 25000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fchu-bai-hong_postcard.png?alt=media&token=8ce9d527-fbbd-4df4-ae16-50d6a1f8d16d"
                },
                new Product
                {
                    Id = new Guid("a38d5f4f-1764-4bc0-95b4-979ebd8d7f12"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'CHỦ BÀI'(NÂU)",
                    Description = "Description",
                    Price = 25000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fchu-bai-nau_postcard.png?alt=media&token=be6779b4-8170-4fab-8ff1-b5ec57223bcb"
                },
                new Product
                {
                    Id = new Guid("8503354b-fa6a-4f94-9515-c86220f7bed1"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'DỌN NHÀ'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fdon-nha_postcard.png?alt=media&token=b60c80f4-3a58-4d63-9202-5c9670086ab8"
                },
                new Product
                {
                    Id = new Guid("898c3659-b119-4df7-aecc-015693184abd"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'TẦN TẢO'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Ftan-tao_postcard.png?alt=media&token=42f3a0df-a25e-4284-ab9e-481964d9073e"
                },
                new Product
                {
                    Id = new Guid("2b029c62-3cc7-443e-99e3-fd122eab348e"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'THẦM LẶNG'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Ftham-lang_postcard.png?alt=media&token=a0cb58c2-119c-4e76-bdda-0a64b76ee0cc"
                },
                new Product
                {
                    Id = new Guid("f2f6e7e2-c46e-4218-958e-c56c780f22cb"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'UỐNG TRÀ'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fuong-tra_postcard.png?alt=media&token=9127f6dd-5170-47ab-bf35-63b96d7c8ffa"
                },
                new Product
                {
                    Id = new Guid("fdd02b3f-7e01-4213-ad1c-8c485ccd904f"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "Note",
                    Name = "THIỆP'YÊU THƯƠNG'",
                    Description = "Description",
                    Price = 29000,
                    StockQuantity = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fyeu-thuong_postcard.png?alt=media&token=fec3f6b2-af5b-4149-b6b4-9f37a04efc5b"
                }
                );
        }
    }
}
