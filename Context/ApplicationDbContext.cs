using GenericRepository;
using Microsoft.EntityFrameworkCore;
using NET.GercekHayatProblemleri.Blazor.Models;

namespace NET.GercekHayatProblemleri.Blazor.Context;

public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
}