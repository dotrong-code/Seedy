using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity.Data;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.User.Login;
using Seed.Domain.Entities;

namespace Seed.Application.Interface.IService
{
    public interface IAuthService
    {
        Task<Result> SignIn(LoginRequest loginRequest);
        Task<Result> SignUp(RegisterRequest registerRequest);
        Task<Result> ConfirmEmail(Guid userId);
        public string GenerateJwtToken(string email, int Role, double expirationMinutes);
        public Task<User> FindOrCreateUser(GoogleJsonWebSignature.Payload payload);
    }
}
