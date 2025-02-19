using MediatR;
using OnionWebArchitectureWithUseCases.Application;
using OnionWebArchitectureWithUseCases.Application.Requests;
using OnionWebArchitectureWithUseCases.Application.Requests.Clients;

namespace OnionWebArchitectureWithUseCases.Endpoints.Clients;

public static class CreateClient
{
   public static void CreateClientEndpoint(this IEndpointRouteBuilder app)
   {
      app.MapPost("/client", async (IMediator mediator, CreateClientRequest request) =>
      {
         await mediator.Send(request);
         return Results.Ok();
      });
   }
}