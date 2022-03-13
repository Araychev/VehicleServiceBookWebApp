using Microsoft.EntityFrameworkCore;
using VehicleServiceBook.Infrastructure.Data;
using VehicleServiceBook.Infrastructure.Data.Repositories;

namespace VehicleServiceBook.Api.Extensions
{
    public static class ApiServiceCollectionExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicatioDbRepository, ApplicatioDbRepository>();

            return services;
        }

        public static IServiceCollection AddApiDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
           

            return services;
        }
    }
}
