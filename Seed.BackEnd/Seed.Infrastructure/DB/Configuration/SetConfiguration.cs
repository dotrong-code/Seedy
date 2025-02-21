using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class SetConfiguration : IEntityTypeConfiguration<Set>
    {
        public void Configure(EntityTypeBuilder<Set> builder)
        {
            builder.HasData(
                new Set
                {
                    Id = new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "This product requires a 15-day pre-order.",
                    Name = "“KHỞI\" SET",
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fkhoi_notebook.png?alt=media&token=175005bb-bcbd-48f0-ae3a-769fdf921249",
                    Description = "Peach blossom - the symbol of spring and beginning. \"Khoi\" carries the meaning of a start, where ideas bloom, bringing hope and new promises.",
                    Price = 10000,
                    StockQuantity = 100,

                },
                new Set
                {
                    Id = new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "This product requires a 15-day pre-order.",
                    Name = "“THỨC\" SET",
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fthuc_notebook.png?alt=media&token=05133546-cbc2-4eba-bf96-e8d3f3a653eb",
                    Description = "Flamboyant red of the flamboyant tree – the vibrant color of passion and energy. 'Thuc' marks the awakening, when you are filled with a strong will to face great challenges.",
                    Price = 10000,
                    StockQuantity = 100,
                }




                );
        }
    }
}
