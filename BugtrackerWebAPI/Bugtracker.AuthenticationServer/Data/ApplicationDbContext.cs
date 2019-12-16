using System.Threading.Tasks;
using Bugtracker.AuthenticationServer.Data.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bugtracker.AuthenticationServer.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }

    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            UseRealDataBase(context);

            await context.SaveChangesAsync();
        }

        private static void UseRealDataBase(ApplicationDbContext context)
        {
            context.Database.Migrate();
        }

        private static void UseTestDataBase(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();

            // the database that is created cannot be later updated using migrations.
            context.Database.EnsureCreated();
        }
    }
}
