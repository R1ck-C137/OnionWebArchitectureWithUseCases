using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application;

public record CreateClientRequest(string FirstName, string LastName);

public class CreateClientHandler
{
    private readonly IClientStore _clientStore;

    public CreateClientHandler(IClientStore clientStore)
    {
        _clientStore = clientStore;
    }

    public async Task Handle(CreateClientRequest request)
    {
        var client = new Client
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        await _clientStore.Create(client);
    }
}