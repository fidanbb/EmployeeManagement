using EmployeeManagement.Application.Dtos.EmployeeDtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<Paginate<ResultEmployeeDto>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        Task<List<ResultEmployeeDto>> GetAllAsync();
        Task<List<ResultEmployeeDto>> GetWhereAsync(Expression<Func<Employee, bool>> method);
        Task<Paginate<ResultEmployeeDto>> FilterEmployeesAsync(EmployeeFilterDto filterDto);
        Task<ResultEmployeeDto> GetSingleAsync(Expression<Func<Employee, bool>> method);
        Task<ResultEmployeeDto> GetByIdAsync(int id);
        Task AddAsync(CreateEmployeeDto model);
        Task<bool> RemoveAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateEmployeeDto model);
    }
}
