using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfSample.DataAccessLayer
{
    public class ShopDbContextFactory : IDesignTimeDbContextFactory<ShopDbContext>
    {
        ShopDbContext IDesignTimeDbContextFactory<ShopDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>();

            optionsBuilder.UseSqlServer("");

            return new ShopDbContext(optionsBuilder.Options);
        }
    }
}
