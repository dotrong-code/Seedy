using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Validator.Abstract;
using Seed.Application.DTOs.User.Register;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.User.Update;

namespace Seed.Application.Common.Validator.UserVali
{
    public class UpdateUserValidator :UserValidator<UpdateUserRequest>
    {
        public UpdateUserValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddEmailRules(request => request.Email, checkExists: true);
            AddUserNameRules(request => request.UserName, checkExists: true);
            AddFullNameRules(request => request.FullName);
            AddPhoneNumberRules(request => request.PhoneNumber);
            AddAddressRules(request => request.Address);
            AddBirthdayRules(x => x.DateOfBirth);
        }
    }
}
