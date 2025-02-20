using MediatR;
using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Command;

public record CreateClientCommand(string FirstName, string LastName) : IRequest<Unit>;

public class CreateClientHandler(IClientStore clientStore) : IRequestHandler<CreateClientCommand, Unit>
{
    public async Task<Unit> Handle(CreateClientCommand command, CancellationToken cancellationToken)
    {
        var client = new Client
        {
            FirstName = command.FirstName,
            LastName = command.LastName
        };
        await clientStore.Create(client);

        return Unit.Value;
    }
}