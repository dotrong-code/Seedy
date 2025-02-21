namespace Seed.Infrastructure.DTOs.Set.Get
{
    public class GetSetDetail
    {
        public Guid Id { get; set; }
        public List<string> ListImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

    }
}
