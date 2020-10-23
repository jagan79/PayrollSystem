using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
