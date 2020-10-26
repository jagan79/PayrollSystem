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


        public EmployeeService(IEmployeeRepository employeeRepository, IMediatorHandler bus)
        {
            _employeeRepository = employeeRepository;
            _bus = bus;
        }

        public void Create(EmployeeViewModel employeeViewModel)
        {
            var createEmployeeCommand = new CreateEmployeeCommand (
                employeeViewModel.IDNumber,
                employeeViewModel.LastName,
                employeeViewModel.FirstName,
                employeeViewModel.MiddleName,
                employeeViewModel.SSSNumber,
                employeeViewModel.PhilHealthNumber,
                employeeViewModel.HDMFNumber,
                employeeViewModel.PositionId,
                employeeViewModel.HireDate,
                employeeViewModel.EndHireDate,
                employeeViewModel.ReHireDate,
                employeeViewModel.BasicRate
                );

            _bus.SendCommand(createEmployeeCommand);
        }

        public EmployeeViewModel GetEmployees()
        {
            return new EmployeeViewModel()
            {
                Employees = _employeeRepository.GetEmployees()
            };
        }
    }
}
