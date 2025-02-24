namespace OnionWebArchitectureWithUseCases.Application.Common.Exceptons;

public class NotFoundException(string name, object key) : Exception($"Entity \"{name}\" ({key}) not found.");