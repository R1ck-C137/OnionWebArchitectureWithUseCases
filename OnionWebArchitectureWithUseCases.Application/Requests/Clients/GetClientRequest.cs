using OnionWebArchitectureWithUseCases.Core.Models;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Application.Requests.Clients;
using MediatR;

public record GetClientRequest(Guid Id) : IRequest<Client>;

public class GetClientHandler(IClientStore clientStore) : IRequestHandler<GetClientRequest, Client>
{
    public async Task<Client> Handle(GetClientRequest request, CancellationToken cancellationToken)
    {
        return await clientStore.GetById(request.Id);
    }
}