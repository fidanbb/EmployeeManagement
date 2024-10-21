using EmployeeManagement.Application.Dtos.CompanyDtos;
using FluentValidation;

namespace EmployeeManagement.Application.Validators.CompanyValidators
{
    public class CreateCompanyValidator:AbstractValidator<CreateCompanyDto>
    {
        public CreateCompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Company Name is required")
                                .Length(2, 100).WithMessage("Company Name must be between 2 and 100 characters.");
        }
    }
}
