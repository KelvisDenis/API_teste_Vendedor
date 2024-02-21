using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura {

    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptions)
         => contextOptions.UseNpgsql("Server=localhost;"
             + "Port=5432;" +
             "User ID=postgres;" +
             "Database=postgres;" +
             "Password=M@c1234567;");

    }
}