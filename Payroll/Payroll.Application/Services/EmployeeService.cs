using Payroll.Application.Interfaces;
using Payroll.Application.ViewModels;
using Payroll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
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
