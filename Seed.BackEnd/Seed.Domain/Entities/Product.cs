namespace Seed.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductCategoryId { get; set; } //Notebook,Postcard,Sticker,Evelope
        public string Note { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public Guid? OccasionId { get; set; }
        public Occasion? Occasion { get; set; }
        public ICollection<SetProduct>? SetProducts { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<CartItem> CartItems { get; set; } // Add this navigation property
        public ProductCategory ProductCategory { get; set; } // Navigation property for relationship
    }
}
