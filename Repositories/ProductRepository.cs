using GenericRepository;
using NET.GercekHayatProblemleri.Blazor.Context;
using NET.GercekHayatProblemleri.Blazor.Models;

namespace NET.GercekHayatProblemleri.Blazor.Repositories;

public sealed class ProductRepository : Repository<Product, ApplicationDbContext>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
