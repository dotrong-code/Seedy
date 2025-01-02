using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.User.Login;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.Interfaces;

namespace Seed.Application.Implement.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthService
            (
            IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Result> SignIn(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
