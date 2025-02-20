using MediatR;
using OnionWebArchitectureWithUseCases.Application.Clients.Command;

namespace OnionWebArchitectureWithUseCases.Endpoints.Clients;

public static class CreateClient
{
   public static void CreateClientEndpoint(this IEndpointRouteBuilder app)
   {
      app.MapPost("/client", async (IMediator mediator, CreateClientCommand request) =>
      {
         await mediator.Send(request);
         return Results.Ok();
      });
   }
}