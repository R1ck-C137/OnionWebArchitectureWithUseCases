using MediatR;
using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Requests.Clients;

public record CreateClientRequest(string FirstName, string LastName) : IRequest<Unit>;

public class CreateClientHandler(IClientStore clientStore) : IRequestHandler<CreateClientRequest, Unit>
{
    public async Task<Unit> Handle(CreateClientRequest request, CancellationToken cancellationToken)
    {
        var client = new Client
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        await clientStore.Create(client);

        return Unit.Value;
    }
}