using EmployeeManagement.Application.Dtos.EmployeeDtos;
using FluentValidation;


namespace EmployeeManagement.Application.Validators.EmployeeValidators
{
    public class EmployeeFilterValidator : AbstractValidator<EmployeeFilterDto>
    {
        public EmployeeFilterValidator()
        {

            RuleFor(x => x.PageNumber)
                .NotEmpty()
                .WithMessage("Page Number is required")
                .GreaterThan(0)
                .WithMessage("Page number must be greater than zero.");

            RuleFor(x => x.PageSize)
             .NotEmpty()
             .WithMessage("Page Size is required");
           
        }
    }
}
