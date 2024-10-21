using EmployeeManagement.Domain.Entities.Common;
using EmployeeManagement.Domain.Interfaces;
using EmployeeManagement.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EmployeeManagement.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T model)
        {
            await Table.AddAsync(model);
        }
        public async Task<List<T>> GetAllAsync(bool tracking = true)
        {
            IQueryable<T> query = Table;

            if (!tracking)
                query = query.AsNoTracking();

            
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {

            IQueryable<T> query = Table;

            if (!tracking)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync(method);

        }

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);

            if (!tracking)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public void Remove(T model)
        {
            Table.Remove(model);
        }
        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public void Update(T model)
        {
            Table.Update(model);
        }
    }
}
