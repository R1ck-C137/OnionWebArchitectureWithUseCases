using FluentValidation;
using MediatR;
using OnionWebArchitectureWithUseCases.Application.Behaviors;
using OnionWebArchitectureWithUseCases.Application.Clients.Command;
using OnionWebArchitectureWithUseCases.Application.Clients.Validations;
using OnionWebArchitectureWithUseCases.Core.Stores;
using OnionWebArchitectureWithUseCases.Endpoints;
using OnionWebArchitectureWithUseCases.Persistence;

namespace OnionWebArchitectureWithUseCases;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddValidatorsFromAssemblyContaining<CreateClientCommandValidator>();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
            typeof(CreateClientCommand).Assembly
        ));
        builder.Services.AddScoped<IClientStore, ClientRepository>();
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //builder.Services.AddScoped<IMailService, MailService>();
        
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapEndpoints();
        app.UseAuthorization();

        app.Run();
    }
}