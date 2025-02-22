namespace OnionWebArchitectureWithUseCases.Core.Stores;

public interface IMailService
{
    public Task SendWelcomeEmail(Guid clientId);
}