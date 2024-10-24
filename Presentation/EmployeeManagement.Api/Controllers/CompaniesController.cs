using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Application.Validators.CompanyValidators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanies()
        {
            var datas = await _companyService.GetAllAsync();

            return Ok(datas);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompaniesWithPagination(int pageNumber,int pageSize)
        {
            var datas = await _companyService.GetAllWithPaginationAsync(pageNumber,pageSize);

            return Ok(datas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById([FromRoute] int id)
        {
            var data = await _companyService.GetByIdAsync(id);
            return data == null ? NotFound(new { Message = "Company Not Found" }) : Ok(data);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyDto request)
        {
            CreateCompanyValidator validator = new CreateCompanyValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);
         
            var data = await _companyService.GetSingleAsync(m => m.Name == request.Name);

            if (data is not null) return BadRequest(new { Message = "This Company Already Exists" });

            await _companyService.AddAsync(request);

            return Ok(new { Message = "Company Created Successfully" });
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateCompany(int id, [FromBody] UpdateCompanyDto request)
        {
            UpdateCompanyValidator validator = new UpdateCompanyValidator();
            ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var data = await _companyService.GetSingleAsync(m => m.Name == request.Name && m.Id != request.Id);

            if (data is not null) return BadRequest(new { Message = "This Company Already Exists" });
         
            var result = await _companyService.UpdateAsync(id, request);

            return result ? Ok(new { Message = "Company Updated Successfully" })
                           : NotFound(new { Message = "Company Not Found" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var result = await _companyService.RemoveAsync(id);

            return result ? Ok(new { Message = "Company Deleted Successfully" })
                          : NotFound(new { Message = "Company Not Found" });      
        }
    }
}
