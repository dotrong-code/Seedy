using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.User.Login;

namespace Seed.Application.Interface.IService
{
    public interface IAuthService
    {
        Task<Result> SignIn(LoginRequest loginRequest);
    }
}
