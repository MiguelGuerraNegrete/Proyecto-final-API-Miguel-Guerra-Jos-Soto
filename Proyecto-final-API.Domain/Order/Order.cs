namespace Proyecto_final_API.Domain.Order;

public class Order
{
    public Guid OrderId { get; set; }
    public int Units { get; set; }
    public Double ProductValue { get; set; }
    public Double Total { get; set; }
}