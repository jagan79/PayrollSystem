using Payroll.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Domain.Commands
{
    public abstract class EmployeeCommand : Command
    {
        public string IDNumber { get; protected set; }
        public string LastName { get; protected set; }
        public string FirstName { get; protected set; }
        public string MiddleName { get; protected set; }
        public string SSSNumber { get; protected set; }
        public string PhilHealthNumber { get; protected set; }
        public string HDMFNumber { get; protected set; }
        public string PositionId { get; protected set; }
        public DateTime HireDate { get; protected set; }
        public DateTime EndHireDate { get; protected set; }
        public DateTime ReHireDate { get; protected set; }
        public double BasicRate { get; protected set; }
    }
}
