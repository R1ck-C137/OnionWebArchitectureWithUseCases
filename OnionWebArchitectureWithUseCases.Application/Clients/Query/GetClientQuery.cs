using MediatR;
using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Query;

public record GetClientQuery(Guid Id) : IRequest<Client>;

public class GetClientHandler(IClientStore clientStore) : IRequestHandler<GetClientQuery, Client>
{
    public async Task<Client> Handle(GetClientQuery query, CancellationToken cancellationToken)
    {
        return await clientStore.GetById(query.Id);
    }
}