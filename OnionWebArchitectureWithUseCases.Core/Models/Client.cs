﻿namespace OnionWebArchitectureWithUseCases.Core.Models;

public class Client
{
    public Guid Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
}