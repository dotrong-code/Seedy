using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Order;
using Seed.Infrastructure.Interfaces;
using System.Net.Http;
using System.Text;

namespace Seed.Application.Implement.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<PaymentService> _logger;
        private readonly IOrderService _orderService;
        private readonly IUnitOfWork _unitOfWork;
        private const string SePayApiUrl = "https://my.sepay.vn/userapi/transactions/list?limit=5";
        private const string SePayApiKey = "QLT2BNDI0U2HVY9BLT9XCWGP77UA18XLIEWAMQCCNZ5LSC3K8PEFYHWVMBAJSGEG";

        public PaymentService(HttpClient httpClient, ILogger<PaymentService> logger, IOrderService orderService, IUnitOfWork unitOfWork)
        {
            _httpClient = httpClient;
            _logger = logger;
            _orderService = orderService;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> GetAllPaymentsAsync()
        {
            try
            {
                var payments = await _unitOfWork.PaymentRepository.GetAllPaymentsAsync();
                if (payments == null || !payments.Any())
                {
                    return Result.Failure(Error.NotFound("NO_PAYMENTS_FOUND", "No payments found."));
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

                return Result.SuccessWithObject(paymentList);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error fetching payments: {ex.Message}");
                return Result.Failure(Error.Failure("FETCH_PAYMENTS_FAILED", $"Internal Server Error: {ex.Message}"));
            }
        }

        public async Task<Result> CheckPaymentAsync(string accountNumber, decimal amount, string description, Guid userId)
        {
            return await CheckPaymentInternal(accountNumber, amount, description, userId, null);
        }

        public async Task<Result> CreateOrderAndCheckPaymentAsync(OrderRequest orderRequest, Guid userId)
        {
            try
            {
                _logger.LogInformation($"Creating order and checking payment for account: {orderRequest.AccountNumber}, amount: {orderRequest.Amount}, description: {orderRequest.Description}");
                return await CheckPaymentInternal(orderRequest.AccountNumber, orderRequest.Amount, orderRequest.Description, userId, orderRequest);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Server error: {ex.Message}");
                return Result.Failure(Error.Failure("CREATE_AND_CHECK_FAILED", $"Internal Server Error: {ex.Message}"));
            }
        }

        public async Task<Result> CreateOrderCODAsync(OrderRequest orderRequest, Guid userId)
        {
            try
            {
                _logger.LogInformation($"Creating COD order for amount: {orderRequest.Amount}");
                var createOrderRequest = MapToCreateOrderRequest(orderRequest, userId);
                var orderResult = await _orderService.CreateOrderAsync(createOrderRequest);

                return orderResult.IsSuccess
                    ? Result.SuccessWithObject(new { Message = "COD order created successfully" })
                    : Result.Failure(Error.Failure("CREATE_COD_FAILED", "Failed to create COD order."));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Server error: {ex.Message}");
                return Result.Failure(Error.Failure("CREATE_COD_FAILED", $"Internal Server Error: {ex.Message}"));
            }
        }

        private async Task<Result> CheckPaymentInternal(string accountNumber, decimal amount, string description, Guid userId, OrderRequest? orderRequest)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, SePayApiUrl);
            request.Headers.Add("Authorization", $"Bearer {SePayApiKey}");

            var response = await _httpClient.SendAsync(request);
            var jsonString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError($"SePay API error: {response.StatusCode}, Response: {jsonString}");
                return Result.Failure(Error.Failure("SEPAY_API_ERROR", $"Error calling SePay API: {response.StatusCode}, {jsonString}"));
            }

            _logger.LogInformation($"SePay API response: {jsonString}");
            var jsonResponse = JObject.Parse(jsonString);
            var transactions = jsonResponse["transactions"];

            if (transactions == null || !transactions.HasValues)
            {
                _logger.LogWarning("No transactions returned from SePay API.");
                return Result.Failure(Error.NotFound("NO_TRANSACTIONS_FOUND", "No transactions found."));
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

                        var payment = new Payment
                        {
                            UserId = userId,
                            Email = "",
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
                            var createOrderRequest = MapToCreateOrderRequest(orderRequest, userId);
                            var orderResult = await _orderService.CreateOrderAsync(createOrderRequest);
                            if (!orderResult.IsSuccess)
                            {
                                _logger.LogError("Failed to create order after successful payment.");
                                return Result.Failure(Error.Failure("ORDER_CREATION_FAILED", "Failed to create order after successful payment."));
                            }
                        }

                        return Result.SuccessWithObject(transactionData );
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error processing transaction data: {ex.Message}");
                }
            }

            _logger.LogWarning("No matching payment transaction found.");
            return Result.Failure(Error.NotFound("NO_MATCHING_TRANSACTION", "No matching payment transaction found."));
        }

        private CreateOrderRequest MapToCreateOrderRequest(OrderRequest orderRequest, Guid? userId)
        {
            return new CreateOrderRequest
            {
                UserID = userId,
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
}