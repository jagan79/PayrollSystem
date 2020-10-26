using MediatR;
using Payroll.Domain.Commands;
using Payroll.Domain.Interfaces;
using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Payroll.Domain.CommandHandlers
{
    public class EmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, bool>
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Task<bool> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                IDNumber = request.IDNumber,
                LastName = request.LastName,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                SSSNumber = request.SSSNumber,
                PhilHealthNumber = request.PhilHealthNumber,
                HDMFNumber = request.HDMFNumber,
                HireDate = request.HireDate,
                EndHireDate = request.EndHireDate,
                ReHireDate = request.ReHireDate,
                PositionId = request.PositionId,
                BasicRate = request.BasicRate
            };

            _employeeRepository.Add(employee);

            return Task.FromResult(true);
        }
    }
}
