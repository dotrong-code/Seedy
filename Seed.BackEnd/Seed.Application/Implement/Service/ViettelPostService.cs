using Newtonsoft.Json;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.ViettelPost;
using System.Text;

namespace Seed.Application.Implement.Service
{
    public class ViettelPostService : IViettelPostService
    {
        private readonly HttpClient _httpClient;
        private const string LoginUrl = "https://partner.viettelpost.vn/v2/user/Login";
        private const string OwnerConnectUrl = "https://partner.viettelpost.vn/v2/user/ownerconnect";
        private const string BaseUrl = "https://partner.viettelpost.vn/v2/categories/";
        private const string GetPriceUrl = "https://partner.viettelpost.vn/v2/order/getPriceAllNlp";

        public ViettelPostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        #region Viettel Login to get Token
        public async Task<Result> LoginAsync(ViettelLoginRequest request)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(LoginUrl, jsonContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return Result.Failure(Error.Failure("ViettelPost_Login_Failed", $"Login failed: {response.StatusCode}, {responseContent}"));
            }

            var result = JsonConvert.DeserializeObject<ViettelLoginResponse>(responseContent);
            return Result.SuccessWithObject(result);
        }

        public async Task<Result> ConnectOwnerAsync(ViettelLoginRequest request, string token)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, OwnerConnectUrl)
            {
                Content = jsonContent
            };
            requestMessage.Headers.Add("Token", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return Result.Failure(Error.Failure("ViettelPost_OwnerConnect_Failed", $"Owner Connect failed: {response.StatusCode}, {responseContent}"));
            }

            var result = JsonConvert.DeserializeObject<ViettelLoginResponse>(responseContent);
            return Result.SuccessWithObject(result);
        }
        #endregion

        #region Get address for user choose
        // 📌 Get List of Provinces
        public async Task<Result> GetProvincesAsync(string token)
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{BaseUrl}listProvinceById?provinceId=0");
                requestMessage.Headers.Add("Token", token);

                var response = await _httpClient.SendAsync(requestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return Result.Failure(Error.Failure("GetProvinces_Failed", $"Failed to get provinces: {response.StatusCode}, {responseContent}"));
                }

                var result = JsonConvert.DeserializeObject<ViettelProvinceResponse>(responseContent);
                Console.WriteLine(result);
                return Result.SuccessWithObject(result);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("GetProvinces_Exception", ex.Message));
            }
        }

        // 📌 Get List of Districts by Province ID
        public async Task<Result> GetDistrictsAsync(int provinceId, string token)
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{BaseUrl}listDistrict?provinceId={provinceId}");
                requestMessage.Headers.Add("Token", token);

                var response = await _httpClient.SendAsync(requestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return Result.Failure(Error.Failure("GetDistricts_Failed", $"Failed to get districts: {response.StatusCode}, {responseContent}"));
                }

                var result = JsonConvert.DeserializeObject<ViettelDistrictResponse>(responseContent);
                return Result.SuccessWithObject(result);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("GetDistricts_Exception", ex.Message));
            }
        }

        // 📌 Get List of Wards by District ID
        public async Task<Result> GetWardsAsync(int districtId, string token)
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{BaseUrl}listWards?districtId={districtId}");
                requestMessage.Headers.Add("Token", token);

                var response = await _httpClient.SendAsync(requestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return Result.Failure(Error.Failure("GetWards_Failed", $"Failed to get wards: {response.StatusCode}, {responseContent}"));
                }

                var result = JsonConvert.DeserializeObject<ViettelWardResponse>(responseContent);
                return Result.SuccessWithObject(result);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("GetWards_Exception", ex.Message));
            }
        }
        #endregion



        // 📌 Get Pricing for Shipping Services
        public async Task<Result> GetShippingPriceAsync(ViettelShippingPriceRequest request, string token)
        {
            try
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{GetPriceUrl}")
                {
                    Content = jsonContent
                };
                requestMessage.Headers.Add("Token", token);

                var response = await _httpClient.SendAsync(requestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return Result.Failure(Error.Failure("GetShippingPrice_Failed", $"Failed to get shipping prices: {response.StatusCode}, {responseContent}"));
                }

                var result = JsonConvert.DeserializeObject<ViettelShippingPriceResponse>(responseContent);
                return Result.SuccessWithObject(result);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("GetShippingPrice_Exception", ex.Message));
            }
        }
    }
}
