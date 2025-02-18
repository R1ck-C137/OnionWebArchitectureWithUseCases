using OnionWebArchitectureWithUseCases.Core.Models;

namespace OnionWebArchitectureWithUseCases.Core.Stores;

public interface IClientStore
{
    Task<IReadOnlyList<Client>> GetByFilter(ClientFilter filter);

    Task<Client> GetById(Guid id);

    Task<Client> GetByFirstName(string lastName);

    Task<Client> GetByLastName(string lastName);

    Task Create(Client client);
}