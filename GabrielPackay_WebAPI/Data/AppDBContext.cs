using GabrielPackay_WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GabrielPackay_WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}