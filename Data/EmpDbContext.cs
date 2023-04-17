using EmpCoreMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmpCoreMVC.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
