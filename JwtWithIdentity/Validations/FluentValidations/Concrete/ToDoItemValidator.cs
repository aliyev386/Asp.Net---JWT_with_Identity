using FluentValidation;
using JwtWithIdentity.Models.DTOS;
using JwtWithIdentity.Validations.FluentValidations.Abstracts;

namespace JwtWithIdentity.Validations.FluentValidations
{
    public class ToDoItemValidator : GenericValidator<AddToDoItemDTO>
    {
        public ToDoItemValidator()
        {
            RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title boş ola bilməz")
            .MinimumLength(3).WithMessage("Title minimum 3 simvol olmalıdır")
            .MaximumLength(100).WithMessage("Title maksimum 100 simvol ola bilər");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description boş ola bilməz")
                .MinimumLength(5).WithMessage("Description minimum 5 simvol olmalıdır")
                .MaximumLength(500).WithMessage("Description maksimum 500 simvol ola bilər");
        }
    }
}
