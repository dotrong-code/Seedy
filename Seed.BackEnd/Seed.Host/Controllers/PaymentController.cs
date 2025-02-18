using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;

[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PaymentController> _logger;
    private const string SePayApiUrl = "https://my.sepay.vn/userapi/transactions/list?limit=5";
    private const string SePayApiKey = "QLT2BNDI0U2HVY9BLT9XCWGP77UA18XLIEWAMQCCNZ5LSC3K8PEFYHWVMBAJSGEG";

    public PaymentController(HttpClient httpClient, ILogger<PaymentController> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    [HttpGet("check")]
    public async Task<IActionResult> CheckPayment([FromQuery] string accountNumber, [FromQuery] decimal amount, [FromQuery] string description)
    {
        try
        {
            _logger.LogInformation($"Checking payment for account: {accountNumber}, amount: {amount}, description: {description}");

            // Tạo request đến SePay API
            var request = new HttpRequestMessage(HttpMethod.Get, SePayApiUrl);
            request.Headers.Add("Authorization", $"Bearer {SePayApiKey}");

            var response = await _httpClient.SendAsync(request);
            var jsonString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError($"SePay API error: {response.StatusCode}, Response: {jsonString}");
                return StatusCode((int)response.StatusCode, new
                {
                    status = response.StatusCode,
                    payload = new { message = "Error calling SePay API", details = jsonString }
                });
            }

            _logger.LogInformation($"SePay API response: {jsonString}");
            var jsonResponse = JObject.Parse(jsonString);
            var transactions = jsonResponse["transactions"];

            if (transactions == null || !transactions.HasValues)
            {
                _logger.LogWarning("No matching transactions found.");
                return NotFound(new
                {
                    status = 404,
                    payload = new { message = "No transactions found." }
                });
            }

            foreach (var transaction in transactions)
            {
                try
                {
                    string transactionAccount = transaction["account_number"]?.ToString();
                    decimal transactionAmount = decimal.Parse(transaction["amount_in"]?.ToString() ?? "0");
                    string transactionContent = transaction["transaction_content"]?.ToString() ?? "";

                    if (transactionAccount == accountNumber &&
                        transactionAmount == amount &&
                        transactionContent.Contains(description))
                    {
                        var transactionData = new
                        {
                            transactionId = transaction["id"]?.ToString(),
                            bank = transaction["bank_brand_name"]?.ToString(),
                            date = transaction["transaction_date"]?.ToString(),
                            amount = transaction["amount_in"]?.ToString(),
                            description = transaction["transaction_content"]?.ToString()
                        };

                        _logger.LogInformation("Payment confirmed.");
                        return Ok(new
                        {
                            status = 200,
                            payload = new
                            {
                                message = "Payment successful.",
                                data = transactionData
                            }
                        });
                    }
                }
                catch (System.Exception ex)
                {
                    _logger.LogError($"Error processing transaction data: {ex.Message}");
                }
            }

            _logger.LogWarning("No matching payment transaction found.");
            return NotFound(new
            {
                status = 404,
                payload = new { message = "No matching payment transaction found." }
            });
        }
        catch (System.Exception ex)
        {
            _logger.LogError($"Server error: {ex.Message}");
            return StatusCode(500, new
            {
                status = 500,
                payload = new { message = "Internal Server Error", error = ex.Message }
            });
        }
    }
}
