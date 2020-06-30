using BCMWeb.Core.DTOs;
using FluentValidation;
using System;

namespace BCMWeb.Infrastructure.Validators
{
    public class CompanyValidator : AbstractValidator<CompanyDto>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.AdministrativeAddress)
                .NotNull()
                .MinimumLength(10);
            RuleFor(x => x.StateId)
                .NotNull();
            RuleFor(x => x.CityId)
                .NotNull();
            RuleFor(x => x.CountryId)
                .NotNull();
            RuleFor(x => x.GovermentId)
                .NotNull()
                .Length(11, 50);
            RuleFor(x => x.LegalName)
                .NotNull()
                .Length(10, 250);
            RuleFor(x => x.StartDate)
                .NotNull()
                .LessThanOrEqualTo(DateTime.Today);
            RuleFor(x => x.Tradename)
                .NotNull()
                .Length(10, 250);
        }
    }
}
