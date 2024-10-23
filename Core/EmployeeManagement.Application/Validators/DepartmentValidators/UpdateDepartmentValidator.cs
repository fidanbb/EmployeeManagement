using EmployeeManagement.Application.Dtos.DepartmentDtos;
using FluentValidation;

namespace EmployeeManagement.Application.Validators.DepartmentValidators
{
    public class UpdateDepartmentValidator:AbstractValidator<UpdateDepartmentDto>
    {
        public UpdateDepartmentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Department Name is required")
                                .Length(2, 100).WithMessage("Department Name must be between 2 and 100 characters.");

            RuleFor(x => x.CompanyId).NotEmpty().WithMessage("Company Id is required");
        }
    }
}
