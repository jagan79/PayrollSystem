using Payroll.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeViewModel> GetEmployees(); 
    }
}
