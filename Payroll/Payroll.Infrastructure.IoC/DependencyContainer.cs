using Microsoft.Extensions.DependencyInjection;
using Payroll.Application.Interfaces;
using Payroll.Application.Services;
using Payroll.Domain.Interfaces;
using Payroll.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Data Layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        }
    }
}
