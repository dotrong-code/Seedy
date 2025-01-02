using Seed.Infrastructure.Common;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;
using Seed.Infrastructure.Interfaces;

namespace Seed.Host.Starup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            #region Common

            // Common
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            // Common

            #endregion

            return services; // Ensure the IServiceCollection is returned
        }
    }
}
