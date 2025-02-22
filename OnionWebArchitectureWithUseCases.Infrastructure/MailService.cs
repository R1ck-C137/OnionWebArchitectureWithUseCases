using MediatR;
using OnionWebArchitectureWithUseCases.Application.Clients.Events;
using OnionWebArchitectureWithUseCases.Core.Stores;

namespace OnionWebArchitectureWithUseCases.Infrastructure;

public class SendWelcomeEmailHandler : INotificationHandler<ClientCreatedEvent>
{
    private readonly IMailService _mailService;

    public SendWelcomeEmailHandler(IMailService mailService)
    {
        _mailService = mailService;
    }

    public async Task Handle(ClientCreatedEvent notification, CancellationToken cancellationToken)
    {
        //TODO: разобраться когда сюда приходит поток
        await _mailService.SendWelcomeEmail(notification.ClientId); // TODO: переписать это как внешний сервис
    }
}