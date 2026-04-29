using Microsoft.EntityFrameworkCore;
using OrganizationManagementSystem.Models;

namespace OrganizationManagementSystem.Data
{
    public class OrganizationDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=(local)\\SQLEXPRESS;Database=OrganizationDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}