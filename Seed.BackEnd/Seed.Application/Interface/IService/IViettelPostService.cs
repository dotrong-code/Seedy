using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.ViettelPost;

namespace Seed.Application.Interface.IService
{
    public interface IViettelPostService
    {
        Task<Result> LoginAsync(ViettelLoginRequest request);
        Task<Result> ConnectOwnerAsync(ViettelLoginRequest request, string token);
        Task<Result> GetProvincesAsync(string token);
        Task<Result> GetDistrictsAsync(int provinceId, string token);
        Task<Result> GetWardsAsync(int districtId, string token);
        Task<Result> GetShippingPriceAsync(ViettelShippingPriceRequest request, string token);
    }
}
