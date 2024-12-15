using Microsoft.EntityFrameworkCore;
using EmployeeCRUDApp.Data; // Adjust this namespace based on where your 'Employee', 'Position', and 'Program' models are located.
namespace EmployeeCRUDApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}
