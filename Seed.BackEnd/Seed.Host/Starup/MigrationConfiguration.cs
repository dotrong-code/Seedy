using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure.DB;

namespace Seed.Host.Starup
{
    public static class MigrationConfiguration
    {
        public static WebApplication MigrateDatabases(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                MigrateDatabase<SeedContext>(services);
            }
            return webApp;
        }
        private static void MigrateDatabase<TContext>(IServiceProvider services) where TContext : DbContext
        {
            try
            {
                var context = services.GetRequiredService<TContext>();
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<TContext>>();
                logger.LogError(ex, $"An error occurred while migrating the database used on context {typeof(TContext).Name}.");
                throw;
            }
        }
    }
}
