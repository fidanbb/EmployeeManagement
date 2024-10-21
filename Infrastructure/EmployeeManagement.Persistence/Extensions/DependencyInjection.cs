using EmployeeManagement.Domain.Interfaces;
using EmployeeManagement.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Persistence.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped(typeof(IPaginateRepository<>), typeof(PaginateRepository<>));

            return services;
        }
    }
}
