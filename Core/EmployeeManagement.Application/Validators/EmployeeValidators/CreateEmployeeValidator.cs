using EmployeeManagement.Application.Dtos.EmployeeDtos;
using FluentValidation;

namespace EmployeeManagement.Application.Validators.EmployeeValidators
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeDto>
    {
        public CreateEmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Employe Name is required")
                                .Length(2, 100).WithMessage("Employee Name must be between 2 and 100 characters.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Employe Surname is required")
                               .Length(2, 100).WithMessage("Employee Surname must be between 2 and 100 characters.");

            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Birth Date is required")
                                     .Must(date => date <= DateTime.UtcNow).WithMessage("Birth Date must be in the past."); ;

            RuleFor(x => x.DepartmentId).NotEmpty().WithMessage("Department Id is required");
        }
    }
}
