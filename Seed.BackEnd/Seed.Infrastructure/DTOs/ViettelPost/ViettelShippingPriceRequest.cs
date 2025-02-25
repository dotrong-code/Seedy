using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelShippingPriceRequest
    {
        public string SENDER_ADDRESS { get; set; }
        public string RECEIVER_ADDRESS { get; set; }
        public string PRODUCT_TYPE { get; set; } = "HH"; // Default to Goods
        public int PRODUCT_WEIGHT { get; set; }
        public decimal PRODUCT_PRICE { get; set; }
        public string MONEY_COLLECTION { get; set; }
        public int PRODUCT_LENGTH { get; set; } = 12;// Default to Goods
        public int PRODUCT_WIDTH { get; set; } = 15;// Default to Goods
        public int PRODUCT_HEIGHT { get; set; } = 5;// Default to Goods
        public int TYPE { get; set; } = 1;// Default to Goods
    }
}
