using Microsoft.EntityFrameworkCore;
namespace FirstDotNetCoreApp.Models
{
    public class CrudDBContext : DbContext
    {
        public CrudDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { set; get; }
    }
}