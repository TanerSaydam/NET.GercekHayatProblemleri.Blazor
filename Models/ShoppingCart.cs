namespace NET.GercekHayatProblemleri.Blazor.Models;

public sealed class ShoppingCart
{
    public ShoppingCart()
    {
        Id = Guid.CreateVersion7();
    }

    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}
