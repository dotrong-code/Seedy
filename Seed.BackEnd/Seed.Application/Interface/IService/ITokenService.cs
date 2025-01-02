using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Seed.Application.DTOs.Common;

namespace Seed.Application.Interface.IService
{
    public interface ITokenService
    {
        Task<SecurityToken> GenerateTokenAsync(CurrentUserObject currentUserObject);
        Task<dynamic> RenewTokenAsync(RenewTokenDTO tokenDTO);
        Task<string> GenerateAccessTokenAsync(SecurityToken token);
    }
}
