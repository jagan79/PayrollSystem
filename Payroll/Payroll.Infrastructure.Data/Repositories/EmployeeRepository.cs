using Payroll.Domain.Interfaces;
using Payroll.Domain.Models;
using Payroll.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private PayrollDBContext _context;

        public EmployeeRepository(PayrollDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }
    }
}
