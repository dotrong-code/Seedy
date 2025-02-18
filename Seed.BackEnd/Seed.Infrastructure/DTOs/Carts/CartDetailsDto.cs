using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.Carts
{
    public class CartDetailsDto
    {
        public Guid CartID { get; set; }
        public Guid? UserID { get; set; }
        public Dictionary<Guid, ProductCartItemDto> CartItems { get; set; } = new();
    }

    public class ProductCartItemDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductStockQuantity { get; set; }
        public int Quantity { get; set; }
    }
}
