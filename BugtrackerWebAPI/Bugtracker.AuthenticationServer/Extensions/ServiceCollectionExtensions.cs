using System;
using Bugtracker.AuthenticationServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bugtracker.AuthenticationServer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPostgresSyncContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultDbConnection"),
                    builder => builder.SetPostgresVersion(new Version("12.0")));
            });

            return services;
        }
    }
}
