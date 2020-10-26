using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Payroll.Application.Interfaces;
using Payroll.Application.Services;
using Payroll.Domain.CommandHandlers;
using Payroll.Domain.Commands;
using Payroll.Domain.Core.Bus;
using Payroll.Domain.Interfaces;
using Payroll.Infrastructure.Bus;
using Payroll.Infrastructure.Data.Context;
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
            //Domain InMemory Bus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateEmployeeCommand, bool>, EmployeeCommandHandler>();

            //Application Layer
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Data Layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<PayrollDBContext>();

        }
    }
}
