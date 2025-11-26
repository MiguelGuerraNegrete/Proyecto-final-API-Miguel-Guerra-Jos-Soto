namespace Proyecto_final_API.Application.Client;

public interface IClientService
{
    Task<IEnumerable<Domain.Client.Client>> GetAsync();
    Task<Domain.Client.Client> GetByIdAsync(Guid clientId);
    Task SaveAsync(Domain.Client.Client client);
}