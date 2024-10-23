using AutoMapper;
using EmployeeManagement.Application.Dtos.EmployeeDtos;
using EmployeeManagement.Application.Extensions;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using EmployeeManagement.Domain.Interfaces;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPaginateRepository<Employee> _paginateRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository,
                              IPaginateRepository<Employee> paginateRepository,
                              IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _paginateRepository = paginateRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateEmployeeDto model)
        {
            var mappedData = _mapper.Map<Employee>(model);
            await _employeeRepository.AddAsync(mappedData);
            await _employeeRepository.SaveAsync();
        }

        public async Task<List<ResultEmployeeDto>> GetAllAsync()
        {
            var datas = await _employeeRepository.GetAllAsync();
            var mappedDatas = _mapper.Map<List<ResultEmployeeDto>>(datas);

            return mappedDatas;
        }

        public async Task<Paginate<ResultEmployeeDto>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            var datas = await _employeeRepository.GetAllAsync();
            var mappedDatas = _mapper.Map<List<ResultEmployeeDto>>(datas);

            return _paginateRepository.PaginatedData(mappedDatas, pageNumber, pageSize);

        }

        public async Task<ResultEmployeeDto> GetByIdAsync(int id)
        {
            var data = await _employeeRepository.GetByIdAsync(id);

            if (data is null) return null;

            return _mapper.Map<ResultEmployeeDto>(data);
        }

        public async Task<ResultEmployeeDto> GetSingleAsync(Expression<Func<Employee, bool>> method)
        {
            var data = await _employeeRepository.GetSingleAsync(method);

            if (data is null) return null;

            return _mapper.Map<ResultEmployeeDto>(data);
        }

        public async Task<List<ResultEmployeeDto>> GetWhereAsync(Expression<Func<Employee, bool>> method)
        {
            var datas = await _employeeRepository.GetWhereAsync(method);
            var mappedDatas = _mapper.Map<List<ResultEmployeeDto>>(datas);

            return mappedDatas;
        }
        public async Task<Paginate<ResultEmployeeDto>> FilterEmployeesAsync(EmployeeFilterDto filterDto)
        {
            Expression<Func<Employee, bool>> filter = e => true;

            if (!string.IsNullOrEmpty(filterDto.Name))
            {
                filter = filter.And(e => e.Name.Trim().ToLower().Contains(filterDto.Name.Trim().ToLower()));
            }

            if (!string.IsNullOrEmpty(filterDto.Surname))
            {
                filter = filter.And(e => e.Surname.Trim().ToLower().Contains(filterDto.Surname.Trim().ToLower()));
            }

            if (!string.IsNullOrEmpty(filterDto.DepartmentName))
            {
                filter = filter.And(e => e.Department.Name.Trim().ToLower().Contains(filterDto.DepartmentName.Trim().ToLower()));
            }

            if (!string.IsNullOrEmpty(filterDto.CompanyName))
            {
                filter = filter.And(e => e.Department.Company.Name.Trim().ToLower().Contains(filterDto.CompanyName.Trim().ToLower()));
            }

            if (filterDto.DepartmentId.HasValue)
            {
                filter = filter.And(e => e.DepartmentId == filterDto.DepartmentId.Value);
            }

            if (filterDto.CompanyId.HasValue)
            {
                filter = filter.And(e => e.Department.CompanyId == filterDto.CompanyId.Value);
            }

            var employees = await _employeeRepository.GetWhereAsync(filter);

            var mappedEmployees = _mapper.Map<List<ResultEmployeeDto>>(employees);

            return _paginateRepository.PaginatedData(mappedEmployees, filterDto.PageNumber, filterDto.PageSize);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var data = await _employeeRepository.GetByIdAsync(id);

            if (data is null) return false;

            _employeeRepository.Remove(data);
            await _employeeRepository.SaveAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(int id, UpdateEmployeeDto model)
        {
            var data = await _employeeRepository.GetByIdAsync(id);

            if (data is null) return false;

            _mapper.Map(model, data);

            _employeeRepository.Update(data);
            await _employeeRepository.SaveAsync();

            return true;
        }
    }
}
