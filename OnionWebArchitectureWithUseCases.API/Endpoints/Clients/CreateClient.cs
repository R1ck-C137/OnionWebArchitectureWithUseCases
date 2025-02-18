using OnionWebArchitectureWithUseCases.Application;

namespace OnionWebArchitectureWithUseCases.Endpoints.Clients;

public static class CreateClient
{
   public static void CreateClientEndpoint(this IEndpointRouteBuilder app)
   {
      app.MapPost("/client", Create);
   }

   private static async Task<IResult> Create(
      CreateClientHandler handler, 
      CreateClientRequest request)
   {
      await handler.Handle(request);
      return Results.Ok();
   }
}