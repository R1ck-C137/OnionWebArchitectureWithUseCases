namespace OnionWebArchitectureWithUseCases.Core.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public List<(Guid ProductId, int Count)> Products { get; set; }
}