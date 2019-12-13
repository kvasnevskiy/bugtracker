using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bugtracker.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace Bugtracker.DataAccessLayer
{
    public sealed class BugtrackerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; } 

        public BugtrackerDbContext(DbContextOptions<BugtrackerDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProject>()
                .HasKey(up => new { up.UserId, up.ProjectId });
            modelBuilder.Entity<UserProject>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(up => up.UserId);
            modelBuilder.Entity<UserProject>()
                .HasOne(up => up.Project)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(up => up.ProjectId);
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
