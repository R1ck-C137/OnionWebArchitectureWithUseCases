using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Persistence;

public class ClientRepository : IClientStore
{
    public Task<IReadOnlyList<Client>> GetByFilter(ClientFilter filter)
    {
        throw new NotImplementedException();
    }

    public Task<Client> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> GetByFirstName(string lastName)
    {
        throw new NotImplementedException();
    }

    public Task<Client> GetByLastName(string lastName)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> Create(Client client)
    {
        return new Guid();
    }
}