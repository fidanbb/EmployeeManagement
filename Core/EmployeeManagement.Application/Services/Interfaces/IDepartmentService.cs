using EmployeeManagement.Application.Dtos.DepartmentDtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<Paginate<ResultDepartmentDto>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        Task<List<ResultDepartmentDto>> GetAllAsync();
        Task<List<ResultDepartmentDto>> GetWhereAsync(Expression<Func<Department, bool>> method);
        Task<ResultDepartmentDto> GetSingleAsync(Expression<Func<Department, bool>> method);
        Task<ResultDepartmentDto> GetByIdAsync(int id);
        Task AddAsync(CreateDepartmentDto model);
        Task<bool> RemoveAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateDepartmentDto model);
    }
}
