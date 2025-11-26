namespace Proyecto_final_API.Domain.Product;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAsync();
    Task<Product> GetByIdAsync(Guid productId);
    Task SaveAsync(Product product);
}