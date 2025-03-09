using Fidlle.Application.DTO;
using FluentValidation;

namespace Fidlle.Application.Validators
{
    public class CreateCharacterDtoValidator : AbstractValidator<CreateCharacterDto>
    {
        public CreateCharacterDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MinimumLength(3).WithMessage("Name must be at least 3 characters long.")
                .MaximumLength(15).WithMessage("Name cannot exceed 15 characters.");

            RuleFor(x => x.Class)
                .NotEmpty().WithMessage("Class is required.");
        }
    }
}
