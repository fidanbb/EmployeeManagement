﻿using EmployeeManagement.Application.Services;
using EmployeeManagement.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();  

            return services;
        }
    }
}
