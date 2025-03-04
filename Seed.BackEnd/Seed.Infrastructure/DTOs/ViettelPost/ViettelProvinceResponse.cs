using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelProvinceResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<ProvinceData> Data { get; set; }
    }

    public class ProvinceData
    {
        [JsonProperty("PROVINCE_ID")]
        public int ProvinceId { get; set; }

        [JsonProperty("PROVINCE_CODE")]
        public string ProvinceCode { get; set; }

        [JsonProperty("PROVINCE_NAME")]
        public string ProvinceName { get; set; }
    }   
}
    