using Bogus;
using GenericRepository;
using Microsoft.EntityFrameworkCore;
using NET.GercekHayatProblemleri.Blazor.Components;
using NET.GercekHayatProblemleri.Blazor.Context;
using NET.GercekHayatProblemleri.Blazor.Models;
using NET.GercekHayatProblemleri.Blazor.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseInMemoryDatabase("MyDb");
});

builder.Services.AddHttpClient();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scoped = app.Services.CreateScope())
{
    var dbContext = scoped.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    List<Product> products = new();

    for (int i = 0; i < 10; i++)
    {
        Faker faker = new();
        Product product = new()
        {
            Name = faker.Commerce.ProductName(),
            Stock = new Random().Next(10, 100),
            Price = new Random().Next(100, 100000),
        };
        products.Add(product);
    }

    List<ShoppingCart> shoppingCarts = new();
    for (int i = 0; i < 2; i++)
    {
        ShoppingCart shoppingCart1 = new()
        {
            ProductId = products[i].Id,
            Quantity = new Random().Next(1, 50)
        };
        shoppingCarts.Add(shoppingCart1);

        ShoppingCart shoppingCart2 = new()
        {
            ProductId = products[i].Id,
            Quantity = new Random().Next(1, 50)
        };
        shoppingCarts.Add(shoppingCart2);
    }

    dbContext.AddRange(products);
    dbContext.AddRange(shoppingCarts);
    dbContext.SaveChanges();
}

app.Run();