using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payroll.Application.Interfaces;
using Payroll.Application.ViewModels;

namespace Payroll.Api.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeViewModel employeeViewModel)
        {
            _employeeService.Create(employeeViewModel);

            return Ok(employeeViewModel);
        }
    }
}
