using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}
