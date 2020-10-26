using AutoMapper;
using AutoMapper.QueryableExtensions;
using Payroll.Application.Interfaces;
using Payroll.Application.ViewModels;
using Payroll.Domain.Commands;
using Payroll.Domain.Core.Bus;
using Payroll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMediatorHandler bus, IMapper automapper)
        {
            _employeeRepository = employeeRepository;
            _bus = bus;
            _autoMapper = automapper;
        }

        public void Create(EmployeeViewModel employeeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateEmployeeCommand>(employeeViewModel));
        }

        public IEnumerable<EmployeeViewModel> GetEmployees()
        {
            return _employeeRepository.GetEmployees().ProjectTo<EmployeeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
