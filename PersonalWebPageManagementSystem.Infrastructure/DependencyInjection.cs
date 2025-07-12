using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebPageManagementSystem.Application.Services;
using PersonalWebPageManagementSystem.Domain.Interfaces;
using PersonalWebPageManagementSystem.Infrastructure.Persistence;
using PersonalWebPageManagementSystem.Infrastructure.Repositories;

namespace PersonalWebPageManagementSystem.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Database Context
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                services.AddDbContext<PersonalWebPageContext>(options =>
                    options.UseSqlite(configuration.GetConnectionString("WPMSContextSQLite")));
            }
            else
            {
                services.AddDbContext<PersonalWebPageContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("WPMSContextSQLServer")));
            }

            // Repository Pattern
            services.AddScoped<IResumeRepository, ResumeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Application Services
            services.AddScoped<IResumeService, ResumeService>();

            return services;
        }
    }
}
