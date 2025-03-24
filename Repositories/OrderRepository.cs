using GenericRepository;
using NET.GercekHayatProblemleri.Blazor.Context;
using NET.GercekHayatProblemleri.Blazor.Models;

namespace NET.GercekHayatProblemleri.Blazor.Repositories;

public sealed class OrderRepository : Repository<Order, ApplicationDbContext>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }
}