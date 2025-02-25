using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;
using Seed.Infrastructure.DTOs.Order;
using Seed.Application.Interface.IService;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces;

[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PaymentController> _logger;
    private const string SePayApiUrl = "https://my.sepay.vn/userapi/transactions/list?limit=5";
    private const string SePayApiKey = "QLT2BNDI0U2HVY9BLT9XCWGP77UA18XLIEWAMQCCNZ5LSC3K8PEFYHWVMBAJSGEG";
    private readonly IOrderService _orderService;
    private readonly IUnitOfWork _unitOfWork;

    public PaymentController(HttpClient httpClient, ILogger<PaymentController> logger, IOrderService orderService, IUnitOfWork unitOfWork)
    {
        _httpClient = httpClient;
        _logger = logger;
        _orderService = orderService;
        _unitOfWork = unitOfWork;
    }


    [HttpGet("all")]
    [Authorize] // Ensure only authenticated users can access this endpoint
    public async Task<IActionResult> GetAllPayments()
    {
        try
        {
            var payments = await _unitOfWork.PaymentRepository.GetAllPaymentsAsync();

            if (payments == null || !payments.Any())
            {
                return NotFound(new { status = 404, payload = new { message = "No payments found." } });
            }

            var paymentList = payments.Select(p => new
            {
                p.Id,
                p.UserId,
                p.Email,
                p.TransactionId,
                p.BankBrandName,
                p.AccountNumber,
                p.Amount,
                p.TransactionContent,
                TransactionDate = p.TransactionDate.ToString("yyyy-MM-dd HH:mm:ss"),
                p.ReferenceNumber
            }).ToList();

            return Ok(new { status = 200, payload = paymentList });
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error fetching payments: {ex.Message}");
            return StatusCode(500, new { status = 500, payload = new { message = "Internal Server Error", error = ex.Message } });
        }
    }


    [HttpGet("check")]
    public async Task<IActionResult> CheckPayment([FromQuery] string accountNumber, [FromQuery] decimal amount, [FromQuery] string description)
    {
        // Giữ nguyên logic cũ nếu cần gọi riêng
        return await CheckPaymentInternal(accountNumber, amount, description, null);
    }

    [HttpPost("create-and-check")]
    [Authorize]
    public async Task<IActionResult> CreateOrderAndCheckPayment([FromBody] OrderRequest orderRequest)
    {
        try
        {
            _logger.LogInformation($"Creating order and checking payment for account: {orderRequest.AccountNumber}, amount: {orderRequest.Amount}, description: {orderRequest.Description}");

            return await CheckPaymentInternal(orderRequest.AccountNumber, orderRequest.Amount, orderRequest.Description, orderRequest);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Server error: {ex.Message}");
            return StatusCode(500, new { status = 500, payload = new { message = "Internal Server Error", error = ex.Message } });
        }
    }

    [HttpPost("create-cod")]
    [Authorize]
    public async Task<IActionResult> CreateOrderCOD([FromBody] OrderRequest orderRequest)
    {
        try
        {
            _logger.LogInformation($"Creating COD order for amount: {orderRequest.Amount}");

            var createOrderRequest = MapToCreateOrderRequest(orderRequest);
            var orderResult = await _orderService.CreateOrderAsync(createOrderRequest);

            if (!orderResult.IsSuccess)
            {
                _logger.LogError("Failed to create COD order.");
                return StatusCode(500, new { status = 500, payload = new { message = "Failed to create COD order." } });
            }

            return Ok(new { status = 200, payload = new { message = "COD order created successfully." } });
        }
        catch (Exception ex)
        {
            _logger.LogError($"Server error: {ex.Message}");
            return StatusCode(500, new { status = 500, payload = new { message = "Internal Server Error", error = ex.Message } });
        }
    }
    private async Task<IActionResult> CheckPaymentInternal(string accountNumber, decimal amount, string description, OrderRequest? orderRequest)
    {
        // Extract UserId from the token
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Or "sub" depending on your token configuration
        if (!Guid.TryParse(userIdClaim, out var userId))
        {
            _logger.LogError("Invalid or missing UserId in token.");
            return Unauthorized(new { status = 401, payload = new { message = "Invalid or missing UserId in token." } });
        }

        var request = new HttpRequestMessage(HttpMethod.Get, SePayApiUrl);
        request.Headers.Add("Authorization", $"Bearer {SePayApiKey}");

        var response = await _httpClient.SendAsync(request);
        var jsonString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            _logger.LogError($"SePay API error: {response.StatusCode}, Response: {jsonString}");
            return StatusCode((int)response.StatusCode, new { status = response.StatusCode, payload = new { message = "Error calling SePay API", details = jsonString } });
        }

        _logger.LogInformation($"SePay API response: {jsonString}");
        var jsonResponse = JObject.Parse(jsonString);
        var transactions = jsonResponse["transactions"];

        if (transactions == null || !transactions.HasValues)
        {
            _logger.LogWarning("No transactions returned from SePay API.");
            return NotFound(new { status = 404, payload = new { message = "No transactions found." } });
        }

        _logger.LogInformation($"Checking {transactions.Count()} transactions for match...");
        foreach (var transaction in transactions)
        {
            try
            {
                string transactionAccount = transaction["account_number"]?.ToString();
                decimal transactionAmount = decimal.Parse(transaction["amount_in"]?.ToString() ?? "0");
                string transactionContent = transaction["transaction_content"]?.ToString() ?? "";

                _logger.LogInformation($"Transaction: account={transactionAccount}, amount={transactionAmount}, content={transactionContent}");

                if (transactionAccount == accountNumber && transactionAmount == amount && transactionContent.Contains(description))
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

                    // Save payment information to the database
                    var payment = new Payment
                    {
                        UserId = userId, // Use the UserId from the token
                        Email ="",
                        TransactionId = transaction["id"]?.ToString(),
                        BankBrandName = transaction["bank_brand_name"]?.ToString(),
                        AccountNumber = transactionAccount,
                        Amount = transactionAmount,
                        TransactionContent = transactionContent,
                        TransactionDate = DateTime.Parse(transaction["transaction_date"]?.ToString()),
                        ReferenceNumber = transaction["reference_number"]?.ToString()
                    };

                    await _unitOfWork.PaymentRepository.CreatePaymentAsync(payment);

                    if (orderRequest != null)
                    {
                        var createOrderRequest = MapToCreateOrderRequest(orderRequest);
                        var orderResult = await _orderService.CreateOrderAsync(createOrderRequest);
                        if (!orderResult.IsSuccess)
                        {
                            _logger.LogError("Failed to create order after successful payment.");
                            return StatusCode(500, new { status = 500, payload = new { message = "Failed to create order after successful payment." } });
                        }
                    }

                    return Ok(new { status = 200, payload = new { message = "Payment successful.", data = transactionData } });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error processing transaction data: {ex.Message}");
            }
        }

        _logger.LogWarning("No matching payment transaction found.");
        return NotFound(new { status = 404, payload = new { message = "No matching payment transaction found." } });
    }
    private CreateOrderRequest MapToCreateOrderRequest(OrderRequest orderRequest)
    {
        // Lấy UserID từ token
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Hoặc "sub" tùy cấu hình token
        Guid? userId = userIdClaim != null && Guid.TryParse(userIdClaim, out var parsedId) ? parsedId : (Guid?)null;

        return new CreateOrderRequest
        {
            UserID = userId, // Gán UserID từ token, hoặc null nếu không có token
            ReceiverFullName = orderRequest.Receiver.FullName,
            ReceiverAddress = orderRequest.Receiver.Address,
            ReceiverPhone = orderRequest.Receiver.Phone,
            ReceiverEmail = orderRequest.Receiver.Email,
            ReceiverWard = orderRequest.Receiver.WardId,
            ReceiverDistrict = orderRequest.Receiver.DistrictId,
            ReceiverProvince = orderRequest.Receiver.ProvinceId,
            TotalPrice = orderRequest.Amount,
            ShippingFee = orderRequest.ShippingFee,
            OrderService = "VCN",
            OrderNote = "cho xem hàng, không cho thử",
            MoneyCollection = orderRequest.Amount,
            OrderItems = orderRequest.Items.Select(item => new OrderItemRequest
            {
                ProductId = Guid.Parse(item.ProductId),
                Quantity = item.Quantity,
                Price = item.Price
            }).ToList()
        };
    }
}

public class OrderRequest
{
    public string AccountNumber { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public decimal ShippingFee { get; set; }
    public List<OrderItem> Items { get; set; }
    public ReceiverInfo Receiver { get; set; }
}

public class OrderItem
{
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class ReceiverInfo
{
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int WardId { get; set; }
    public int DistrictId { get; set; }
    public int ProvinceId { get; set; }
}