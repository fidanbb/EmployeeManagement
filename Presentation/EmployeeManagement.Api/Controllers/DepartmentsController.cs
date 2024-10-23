using EmployeeManagement.Application.Dtos.DepartmentDtos;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Application.Validators.DepartmentValidators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly ICompanyService _companyService;
        public DepartmentsController(IDepartmentService departmentService, ICompanyService companyService)
        {
            _departmentService = departmentService;
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var datas = await _departmentService.GetAllAsync();

            return Ok(datas);
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsWithPagination(int pageNumber, int pageSize)
        {
            var datas = await _departmentService.GetAllWithPaginationAsync(pageNumber, pageSize);

            return Ok(datas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById([FromRoute] int id)
        {
            var data = await _departmentService.GetByIdAsync(id);

            if (data == null) return NotFound(new { Message = "Department Not Found" });

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentDto request)
        {
            CreateDepartmentValidator validator = new CreateDepartmentValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var company = await _companyService.GetByIdAsync(request.CompanyId);

            if(company is null) return NotFound(new {Message = "Company Not Found" });
          
            var data = await _departmentService.GetSingleAsync(m => m.Name == request.Name && m.CompanyId == request.CompanyId);

            if (data is not null) return BadRequest(new { Message = "This Department Already Exists in the same Company" });

            await _departmentService.AddAsync(request);

            return Ok(new { Message = "Department Created Successfully" });
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] UpdateDepartmentDto request)
        {
            UpdateDepartmentValidator validator = new UpdateDepartmentValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var company = await _companyService.GetByIdAsync(request.CompanyId);

            if (company is null) return NotFound(new { Message = "Company Not Found" });

            var data = await _departmentService.GetSingleAsync(m => m.Name == request.Name && m.CompanyId == request.CompanyId && m.Id != request.Id);

            if (data is not null) return BadRequest(new { Message = "This Department Already Exists in the same Company" });
        
            var result = await _departmentService.UpdateAsync(id, request);

            if (!result) return NotFound(new { Message = "Department Not Found" });

            return Ok(new { Message = "Department Updated Successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var result = await _departmentService.RemoveAsync(id);

            if (!result) return NotFound(new { Message = "Department Not Found" });

            return Ok(new { Message = "Department Deleted Successfully" });
        }
    }
}
