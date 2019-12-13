using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bugtracker.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bugtracker.DataAccessLayer
{
    public sealed class BugtrackerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public BugtrackerDbContext(DbContextOptions<BugtrackerDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

    public class BugtrackerDbContextSeed
    {
        public static async Task SeedAsync(BugtrackerDbContext context)
        {
            UseRealDataBase(context);

            await context.SaveChangesAsync();
        }

        private static void UseRealDataBase(BugtrackerDbContext context)
        {
            context.Database.Migrate();
        }

        private static void UseTestDataBase(BugtrackerDbContext context)
        {
            context.Database.EnsureDeleted();

            // the database that is created cannot be later updated using migrations.
            context.Database.EnsureCreated();
        }
    }
}
