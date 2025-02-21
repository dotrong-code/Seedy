namespace Seed.Domain.Entities
{
    public class SetProduct
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid SetId { get; set; }
        public Set? Set { get; set; }
    }
}
