using EmployeeManagement.Application.Dtos.EmployeeDtos;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Application.Validators.EmployeeValidators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeesController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {

            var datas = await _employeeService.GetAllAsync();
            return Ok(datas);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesWithPagination(int pageNumber, int pageSize)
        {
            var datas = await _employeeService.GetAllWithPaginationAsync(pageNumber, pageSize);
            return Ok(datas);
        }

        [HttpGet]
        public async Task<IActionResult> FilterEmployees([FromQuery] EmployeeFilterDto filterDto)
        {
            if (filterDto.Name == null && filterDto.Surname == null
                                      && filterDto.CompanyName == null && filterDto.DepartmentName == null
                                      && filterDto.CompanyId == null && filterDto.DepartmentId == null)
                return BadRequest(new { Message = "At least one filter criterion is required. Please provide a name, surname, company name, or department name." });

            EmployeeFilterValidator validator = new EmployeeFilterValidator();
            ValidationResult validationResult = validator.Validate(filterDto);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var filteredDatas = await _employeeService.FilterEmployeesAsync(filterDto);

            return Ok(filteredDatas);
        }

        [HttpGet("{id}")] 
        public async Task<IActionResult> GetEmployeeById([FromRoute] int id)
        {
            var data = await _employeeService.GetByIdAsync(id);
            return data == null ? NotFound(new { Message = "Employee Not Found" }) : Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDto request)
        {
            CreateEmployeeValidator validator = new CreateEmployeeValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var department = await _employeeService.GetByIdAsync(request.DepartmentId);

            if (department is null) return NotFound(new { Message = "Department Not Found" });

            await _employeeService.AddAsync(request);

            return Ok(new { Message = "Employee Created Successfully" });
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] UpdateEmployeeDto request)
        {
            UpdateEmployeeValidator validator = new UpdateEmployeeValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var deparment = await _departmentService.GetByIdAsync(request.DepartmentId);

            if (deparment is null) return NotFound(new { Message = "Department Not Found" });

            var result = await _employeeService.UpdateAsync(id, request);

            return result ? Ok(new { Message = "Employee Updated Successfully" }) 
                          : NotFound(new { Message = "Employee Not Found" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.RemoveAsync(id);

            return result ? Ok(new { Message = "Employee Deleted Successfully" }) 
                          : NotFound(new { Message = "Employee Not Found" });
        }
    }
}
