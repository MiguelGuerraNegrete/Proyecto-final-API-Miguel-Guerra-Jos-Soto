namespace Proyecto_final_API.Domain.Order;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAsync();
    Task<Order> GetByIdAsync(Guid orderId);
    Task SaveAsync(Order order);
}