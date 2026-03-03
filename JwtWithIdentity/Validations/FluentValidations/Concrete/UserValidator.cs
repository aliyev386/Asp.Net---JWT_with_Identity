using FluentValidation;
using JwtWithIdentity.Models.DTOS;
using JwtWithIdentity.Validations.FluentValidations.Abstracts;

namespace JwtWithIdentity.Validations.FluentValidations
{
    public class UserValidator : GenericValidator<AddUserDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name boş ola bilməz")
                .MaximumLength(50);

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname boş ola bilməz")
                .MaximumLength(50);

            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("Doğum tarixi boş ola bilməz")
                .LessThan(DateTime.Now).WithMessage("Doğum tarixi gələcək tarix ola bilməz");
        }
    }
}
