namespace NET.GercekHayatProblemleri.Blazor.Models;

public sealed class Order
{
    public Order()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
