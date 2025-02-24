using MediatR;
using OnionWebArchitectureWithUseCases.Application.Clients.Querys;

namespace OnionWebArchitectureWithUseCases.Endpoints.Clients;

public static class GetClient
{
    public static void GetClientEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/client/{id:guid}", async (IMediator mediator, Guid id) =>
        {
            var request = new GetClientQuery(id);
            var client = await mediator.Send(request);
            return Results.Ok(client);
        });
    }
}