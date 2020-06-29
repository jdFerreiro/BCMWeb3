using BCMWeb.Core.DTOs;
using FluentValidation;

namespace BCMWeb.Infrastructure.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .Length(10, 250)
                .EmailAddress();
            RuleFor(x => x.Name)
                .NotNull()
                .Length(10, 250);
            RuleFor(x => x.UserCode)
                .NotNull()
                .Length(8, 50);
            RuleFor(x => x.UserPassw)
                .NotNull()
                .Length(8, 50);

        }
    }
}
