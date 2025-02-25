using System.Collections.Generic;

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
        public int DISTRICT_ID { get; set; }
        public string DISTRICT_VALUE { get; set; }
        public string DISTRICT_NAME { get; set; }
        public int PROVINCE_ID { get; set; }
    }
}
