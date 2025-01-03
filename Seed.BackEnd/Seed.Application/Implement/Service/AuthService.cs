using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Google.Apis.Auth;
using Microsoft.Extensions.Configuration;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.DTOs.EmailTemplate;
using Seed.Application.DTOs.User.Login;
using Seed.Application.DTOs.User.Register;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces;

namespace Seed.Application.Implement.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<LoginRequest> _loginRequestValidator;
        private readonly IValidator<RegisterRequest> _registerRequestValidator;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly IEmailTemplateService _emailTemplateService;
        public AuthService
            (
            IUnitOfWork unitOfWork,
            IValidator<RegisterRequest> registerRequestValidator,
            IValidator<LoginRequest> loginRequestValidator,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IConfiguration configuration,
            IEmailService emailService,
            IEmailTemplateService emailTemplateService
            )
        {
            _unitOfWork = unitOfWork;
            _registerRequestValidator = registerRequestValidator;
            _loginRequestValidator = loginRequestValidator;
            
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _configuration = configuration;
            _emailService = emailService;
            _emailTemplateService = emailTemplateService;

        }

        public Task<Result> ConfirmEmail(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindOrCreateUser(GoogleJsonWebSignature.Payload payload)
        {
            throw new NotImplementedException();
        }

        public string GenerateJwtToken(string email, int Role, double expirationMinutes)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> SignIn(LoginRequest loginRequest)
        {
            var validate = await _loginRequestValidator.ValidateAsync(loginRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();

                // Handle errors as needed, e.g., return them in a Result object
                return Result.Failures(errors);
            }
            var userLogin = await _unitOfWork.UserRepository.GetUserByEmailAndPasswordAsync(loginRequest.Email, loginRequest.Password);

            if (userLogin == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            if (!userLogin.IsEmailConfirmed)
            {
                return Result.Failure(Error.NotFound("Confirm", "Your email is not activated yet!!, please confirm your mail"));
            }
            var role = userLogin.Role switch
            {
                1 => "Admin",
                2 => "User",
                3 => "Staff",
                4 => "Customer",
                _ => throw new InvalidOperationException("Unknown role.")
            };
            var c = new CurrentUserObject
            {
                UserId = userLogin.Id,
                Fullname = userLogin.FullName,
                Email = userLogin.Email,
                PhoneNumber = userLogin.PhoneNumber,
                RoleName = role,
            };
            var token = await _tokenService.GenerateTokenAsync(c);
            var accessToken = await _tokenService.GenerateAccessTokenAsync(token);
            //var accessToken =  GenerateJwtToken(c.Email, c.RoleId, 180);
            var loginResponse = new LoginResponse
            {
                ReNewToken = "Test",
                AccessToken = accessToken,
            };

            return Result.SuccessWithObject(loginResponse);
        }

        public async Task<Result> SignUp(RegisterRequest registerRequest)
        {
            var validate = await _registerRequestValidator.ValidateAsync(registerRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var passwordHash = HashPassword(registerRequest.Password);
            User newUser = new User
            {
                Id = Guid.NewGuid(),
                FullName = registerRequest.FullName,
                Email = registerRequest.Email,
                PasswordHash = registerRequest.Password,
                Username = registerRequest.UserName,
                PhoneNumber = registerRequest.PhoneNumber,
                Address = registerRequest.Address,
                DateOfBirth = registerRequest.DateOfBirth,
                Role = 4,

            };

            var createUsre = await _unitOfWork.UserRepository.CreateAsync(newUser);
            if (createUsre == 0)
            {
                return Result.Failure(UserErrorMessage.UserNoCreated());
            }


            var activationLink = $"https://localhost:7283/api/Auth/confirm?userId={newUser.Id}";

            // Send activation email
            var emailBodyResult = await _emailTemplateService.GenerateEmailWithActivationLink("VerifyEmail", activationLink);
            if (emailBodyResult.IsFailure)
            {
                return Result.Failure(Error.Failure("EmailGenerationFailed", "Failed to generate the email body."));
            }
            var emailBody = emailBodyResult.Object as string;

            // Create and send the email
            var mailObject = new MailObject
            {
                ToMailIds = new List<string> { newUser.Email },
                Subject = "Confirm Your Email Address",
                Body = emailBody,
                IsBodyHtml = true
            };

            var sendResult = await _emailTemplateService.SendMail(mailObject);
            if (!sendResult.IsSuccess)
            {
                return Result.Failure(Error.None);
            }
            return Result.SuccessWithObject(new { Message = "Create successfully!!!" });

        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
