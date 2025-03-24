using GenericRepository;
using NET.GercekHayatProblemleri.Blazor.Context;
using NET.GercekHayatProblemleri.Blazor.Models;

namespace NET.GercekHayatProblemleri.Blazor.Repositories;

public sealed class ShoppingCartRepository : Repository<ShoppingCart, ApplicationDbContext>, IShoppingCartRepository
{
    public ShoppingCartRepository(ApplicationDbContext context) : base(context)
    {
    }
}