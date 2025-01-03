using Seed.Infrastructure.Common;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;
using Seed.Infrastructure.Interfaces;
using Seed.Application.Implement.Service;
using Seed.Application.Interface.IService;
using FluentValidation;
using Seed.Application.Common.Validator.UserVali;
using Seed.Application.DTOs.User.Login;
using Seed.Infrastructure.Implement.Repositories;
using Seed.Infrastructure.Interfaces.IRepositories;
using Seed.Domain.Entities;

namespace Seed.Host.Starup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {

            #region Validator
            services.AddTransient<IValidator<LoginRequest>, LoginValidator>();
            #endregion
            #region Common

            // Common
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            // Common

            #endregion
            #region Service
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<ITokenService, TokenService>();
            #endregion
            #region Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion
            #region GenericRepositories
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            #endregion
            return services; // Ensure the IServiceCollection is returned
        }
    }
}
