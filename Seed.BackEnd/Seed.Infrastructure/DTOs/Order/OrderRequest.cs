using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DTOs.Order
{
    public class OrderRequest
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public decimal ShippingFee { get; set; }
        public List<OrderItems> Items { get; set; }
        public ReceiverInfo Receiver { get; set; }
    }
    public class ReceiverInfo
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int WardId { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
    }
    public class OrderItems
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
