namespace Proyecto_final_API.Domain.Client;

public interface IClientRepository
{
    Task<IEnumerable<Client>> GetAsync();
    Task<Client> GetByIdAsync(Guid clientId);
    Task SaveAsync(Client client);
}