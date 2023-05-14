using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CrudDotNetCorewithEntity.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
    }
}
