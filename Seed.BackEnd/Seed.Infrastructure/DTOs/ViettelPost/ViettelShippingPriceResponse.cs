using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelShippingPriceResponse
    {
        [JsonProperty("SENDER_ADDRESS")]
        public ViettelAddressInfo SenderAddress { get; set; }

        [JsonProperty("RECEIVER_ADDRESS")]
        public ViettelAddressInfo ReceiverAddress { get; set; }

        [JsonProperty("RESULT")]
        public List<ViettelShippingService> Result { get; set; }
    }

    public class ViettelAddressInfo
    {
        [JsonProperty("PROVINCE_ID")]
        public int ProvinceId { get; set; }

        [JsonProperty("DISTRICT_ID")]
        public int DistrictId { get; set; }

        [JsonProperty("WARD_ID")]
        public int WardId { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }
    }

    public class ViettelShippingService
    {
        [JsonProperty("MA_DV_CHINH")]
        public string maDvChinh { get; set; }

        [JsonProperty("TEN_DICHVU")]
        public string tenDichVu { get; set; }

        [JsonProperty("GIA_CUOC")]
        public decimal giaCuoc { get; set; }

        [JsonProperty("THOI_GIAN")]
        public string thoiGian { get; set; }

        [JsonProperty("EXCHANGE_WEIGHT")]
        public int ExchangeWeight { get; set; }

        [JsonProperty("EXTRA_SERVICE")]
        public List<ViettelExtraService> ExtraServices { get; set; }
    }

    public class ViettelExtraService
    {
        [JsonProperty("SERVICE_CODE")]
        public string serviceCode { get; set; }
        [JsonProperty("SERVICE_NAME")]
        public string serviceName { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string description { get; set; }
    }
}
