using EmployeeManagement.Domain.Helpers.Pagination;
using EmployeeManagement.Domain.Interfaces;

namespace EmployeeManagement.Persistence.Repositories
{
    public class PaginateRepository<T>:IPaginateRepository<T> where T : class
    {
        public Paginate<T> PaginatedData<T>(IEnumerable<T> data, int pageNumber, int pageSize)
        {
            var totalItems = data.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var paginatedData = data
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new Paginate<T>(paginatedData, pageNumber, totalPages);
        }
    }
}
