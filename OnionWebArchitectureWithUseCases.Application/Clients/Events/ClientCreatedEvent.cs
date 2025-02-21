using MediatR;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Events;

public record ClientCreatedEvent(Guid ClientId) : INotification;