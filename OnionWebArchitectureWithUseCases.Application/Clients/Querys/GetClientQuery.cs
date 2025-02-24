using MediatR;
using OnionWebArchitectureWithUseCases.Application.Common.Exceptons;
using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Querys;

public record GetClientQuery(Guid Id) : IRequest<Client>;

public class GetClientHandler(IClientStore clientStore) : IRequestHandler<GetClientQuery, Client>
{
    public async Task<Client> Handle(GetClientQuery query, CancellationToken cancellationToken)
    {
        var client = await clientStore.GetById(query.Id);
        if (client == null)
            throw new NotFoundException(nameof(Client), query.Id);
        
        return client;
    }
}