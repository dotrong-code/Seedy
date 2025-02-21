namespace Seed.Domain.Entities
{
    public class Set : BaseEntity
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid? OccasionId { get; set; }
        public Occasion? Occasion { get; set; }
        public ICollection<SetProduct> SetProducts { get; set; }
    }
}
