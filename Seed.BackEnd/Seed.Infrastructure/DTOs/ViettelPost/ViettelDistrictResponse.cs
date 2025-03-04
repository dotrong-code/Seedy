using System.Collections.Generic;
using Newtonsoft.Json;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelDistrictResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<DistrictData> Data { get; set; }
    }

    public class DistrictData
    {
        [JsonProperty("DISTRICT_ID")]
        public int DistrictId { get; set; }
        [JsonProperty("DISTRICT_VALUE")]
        public string DistrictValue { get; set; }
        [JsonProperty("DISTRICT_NAME")]
        public string DistrictName { get; set; }
        [JsonProperty("PROVINCE_ID")]
        public int ProvinceId { get; set; }
    }
}
