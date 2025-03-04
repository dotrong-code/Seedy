using System.Collections.Generic;
using Newtonsoft.Json;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelWardResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<WardData> Data { get; set; }
    }

    public class WardData
    {
        [JsonProperty("WARDS_ID")]
        public int WardId { get; set; }
        [JsonProperty("WARDS_NAME")]
        public string WardName { get; set; }
        [JsonProperty("DISTRICT_ID")]
        public int DistrictId { get; set; }
    }
}
