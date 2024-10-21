
using EmployeeManagement.Domain.Entities.Common;
using System.Linq.Expressions;

namespace EmployeeManagement.Domain.Interfaces
{
    public interface IGenericRepository<T>where T : BaseEntity
    {
        Task AddAsync(T model);
        Task<List<T>> GetAllAsync(bool tracking = true);
        Task<T> GetByIdAsync(int id, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> method, bool tracking = true);
        void Remove(T model);
        void Update(T model);
        Task SaveAsync();
    }
}
