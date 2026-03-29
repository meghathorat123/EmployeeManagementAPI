using Microsoft.EntityFrameworkCore;

namespace EmpManagement.Data
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<EmpManagement.Models.Employee> Employees { get; set; }

    }
}
