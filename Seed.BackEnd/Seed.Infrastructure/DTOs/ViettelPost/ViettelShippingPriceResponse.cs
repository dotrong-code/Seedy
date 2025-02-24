using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelShippingPriceResponse
    {
        public ViettelAddressInfo SENDER_ADDRESS { get; set; }
        public ViettelAddressInfo RECEIVER_ADDRESS { get; set; }
        public List<ViettelShippingService> RESULT { get; set; }
    }

    public class ViettelAddressInfo
    {
        public int PROVINCE_ID { get; set; }
        public int DISTRICT_ID { get; set; }
        public int WARD_ID { get; set; }
        public string ADDRESS { get; set; }
    }

    public class ViettelShippingService
    {
        public string MA_DV_CHINH { get; set; }
        public string TEN_DICHVU { get; set; }
        public decimal GIA_CUOC { get; set; }
        public string THOI_GIAN { get; set; }
        public int EXCHANGE_WEIGHT { get; set; }
        public List<ViettelExtraService> EXTRA_SERVICE { get; set; }
    }

    public class ViettelExtraService
    {
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
