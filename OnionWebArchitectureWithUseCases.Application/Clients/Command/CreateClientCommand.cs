using MediatR;
using OnionWebArchitectureWithUseCases.Application.Clients.Events;
using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Command;

public record CreateClientCommand(string FirstName, string LastName) : IRequest<Guid>;

public class CreateClientHandler(IClientStore _clientStore, IMediator _mediator) : IRequestHandler<CreateClientCommand, Guid>
{
    public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        var client = new Client
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        var clientId = await _clientStore.Create(client);
        await _mediator.Publish(new ClientCreatedEvent(clientId), cancellationToken); // Событие
        return clientId;
    }
}