namespace OnionWebArchitectureWithUseCases.Core.Stores;

public interface IMailService
{
    public Task SendWelcomeEmail(uint clientId);
}