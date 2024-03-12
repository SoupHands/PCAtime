using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCAtime.Models;
using System.Composition;
using System.Data;

namespace PCAtime.Data
{


    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (locadb)\\MSSQLLocalDB; Initial Catalog = UserDatabase"
                );

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<UserLogins> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TimeLog> TimeEntries
        {
            get; set;

            // public DbSet<Report> Reports { get; set; }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Intern" },
                new Role { RoleId = 2, RoleName = "Supervisor" }
            );
        }



    }
}
