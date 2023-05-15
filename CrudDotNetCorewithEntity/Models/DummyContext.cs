using Microsoft.EntityFrameworkCore;

namespace CrudDotNetCorewithEntity.Models
{
    public class DummyContext : DbContext
    {
        public DummyContext(DbContextOptions<DummyContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
