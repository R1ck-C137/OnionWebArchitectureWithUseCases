using OnionWebArchitectureWithUseCases.Endpoints.Clients;

namespace OnionWebArchitectureWithUseCases.Endpoints;

public static class EndpointExtensions
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.CreateClientEndpoint();
        app.GetClientEndpoint();
    }
}