namespace OnionWebArchitectureWithUseCases.Core.Stores;

public abstract record ClientFilter(
    IEnumerable<Guid> Ids, 
    IEnumerable<string> FirstName, 
    IEnumerable<string> LastName);
