using Microsoft.EntityFrameworkCore;
using NET.GercekHayatProblemleri.Blazor.Models;

namespace NET.GercekHayatProblemleri.Blazor.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
}