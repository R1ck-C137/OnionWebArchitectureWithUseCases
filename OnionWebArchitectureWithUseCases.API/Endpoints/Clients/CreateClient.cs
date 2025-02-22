using MediatR;
using OnionWebArchitectureWithUseCases.Application.Clients.Command;

namespace OnionWebArchitectureWithUseCases.Endpoints.Clients;

public static class CreateClient
{
   public static void CreateClientEndpoint(this IEndpointRouteBuilder app)
   {
      app.MapPost("/client", async (IMediator mediator, CreateClientCommand command) =>
      {
         var clientId = await mediator.Send(command);
         return Results.Created($"/client/{clientId}", new { Id = clientId });
      });
   }
}