using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCAtime.Models;
using System.ComponentModel.DataAnnotations;
using System.Composition;
using System.Data;
using PCAtime;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace PCAtime.Data
{


    public class ApplicationUser : IdentityUser
    {
        public required string Email { get; set; }

        public ApplicationUser(string email)
        {
            Email = email.ToString();
        }
        public required string Password { get; set; }

        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsPasswordConfirmed { get; set;} = false;

    }

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
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

        public DbSet<TimesheetEntry> TimeSheetEntries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Intern" },
                new Role { RoleId = 2, RoleName = "Supervisor" }
            );
            modelBuilder.Entity<UserLogins>()
                .HasKey(u => u.UserId);
        }



    }
}
