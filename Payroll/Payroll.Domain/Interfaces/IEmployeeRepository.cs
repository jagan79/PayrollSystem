using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetEmployees();
        void Add(Employee employee);
    }
}
