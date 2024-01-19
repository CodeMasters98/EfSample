// See https://aka.ms/new-console-template for more information
using EfSample.DataAccessLayer;
using EfSample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Build configuration
var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
var configuration = builder.Build();
string connectionString = configuration.GetConnectionString("DefaultConnection");

// Set up dependency injection
var serviceProvider = new ServiceCollection()
    .AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString))
    .BuildServiceProvider();



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


static void DisplayStates(IEnumerable<EntityEntry> entries)
{
    foreach (var entry in entries)
    {
        Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: { entry.State.ToString()}");
    }
}