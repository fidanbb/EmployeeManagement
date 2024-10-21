using EmployeeManagement.Domain.Helpers.Pagination;

namespace EmployeeManagement.Domain.Interfaces
{
    public interface IPaginateRepository<T>where T : class
    {
        Paginate<T>PaginatedData<T>(IEnumerable<T> data, int pageNumber, int pageSize);
    }
}
