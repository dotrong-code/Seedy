using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.DTOs.User.Login;
using Seed.Infrastructure.Common;
using Seed.Application.Common.Validator.Abstract;

namespace Seed.Application.Common.Validator.UserVali
{
    public class LoginValidator : UserValidator<LoginRequest>
    {
        public LoginValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddEmailRules(request => request.Email);
            AddPasswordRules(request => request.Password);
        }
    }
}
