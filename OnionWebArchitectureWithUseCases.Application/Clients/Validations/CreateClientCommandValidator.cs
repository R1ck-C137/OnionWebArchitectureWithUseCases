using OnionWebArchitectureWithUseCases.Application.Clients.Command;

namespace OnionWebArchitectureWithUseCases.Application.Clients.Validations;

using FluentValidation;

public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
{
    public CreateClientCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Имя клиента не может быть пустым")
            .MaximumLength(100).WithMessage("Имя клиента не может быть длиннее 100 символов");
        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Фамилия клиента не может быть пустым")
            .MaximumLength(100).WithMessage("Фамилия клиента не может быть длиннее 100 символов");
    }
}