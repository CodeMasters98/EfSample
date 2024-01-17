// See https://aka.ms/new-console-template for more information
using EfSample.DataAccessLayer;
using EfSample.Entities;
using Microsoft.Extensions.DependencyInjection;

// Build configuration
//IConfiguration configuration = new ConfigurationBuilder()
//    .SetBasePath(Directory.GetCurrentDirectory())
//    .AddJsonFile("appsettings.json")
//    .Build();

// Set up dependency injection
//var serviceProvider = new ServiceCollection()
//    .AddDbContext<ShopDbContext>(options =>
//        options.UseSqlServer(connectionString))
//    .BuildServiceProvider();

//var serviceProvider = new ServiceCollection()
//            .AddSingleton<IConfiguration>(configuration)
//            .AddDbContextFactory<ShopDbContext, ShopDbContextFactory>()
//            .BuildServiceProvider();

// Use DbContext
using (var context = serviceProvider.GetService<ShopDbContext>())
{
    Product product = new Product()
    {
        Name = "بستنی",
        Price = 12000,
        CreationDate = DateTime.Now
    };
    context.Products.Add(product);
    context.SaveChanges();
}