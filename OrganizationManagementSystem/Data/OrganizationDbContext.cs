using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OrganizationManagementSystem.Models;
using System.Configuration;

namespace OrganizationManagementSystem.Data
{
    public class OrganizationDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connString = ConfigurationManager.ConnectionStrings["OrganizationDb"].ConnectionString;
            options.UseSqlServer(connString);
        }
    }
}