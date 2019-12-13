using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bugtracker.DataAccessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPostgresSyncContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BugtrackerDbContext>(options =>
            {
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultDbConnection"),
                    builder => builder.SetPostgresVersion(new Version("12.0")));
            });

            return services;
        }
    }
}
