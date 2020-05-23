using Microsoft.EntityFrameworkCore;
using productAPI.Models;

namespace productAPI.Data
{

    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opt) : base(opt){ }

        public DbSet<ProductModel> Products { get; set; }
    }

}