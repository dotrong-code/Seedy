namespace Seed.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; } // Foreign key to Order       
        public Guid? ProductId { get; set; } // Optional foreign key to Product
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public Order Order { get; set; }
        public Product? Product { get; set; }

    }
}
