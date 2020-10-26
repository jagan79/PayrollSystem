using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Domain.Commands
{
    public class CreateEmployeeCommand : EmployeeCommand
    {
        public CreateEmployeeCommand(string idnumber, string lastname, string firstname, string midname, string sssnumber, string phealthnumber, string hdmfnumber, string positionid, DateTime hiredate, DateTime endhiredate, DateTime rehiredate, double basicrate)
        {
            IDNumber = idnumber;
            LastName = lastname;
            FirstName = firstname;
            MiddleName = midname;
            SSSNumber = sssnumber;
            PhilHealthNumber = phealthnumber;
            HDMFNumber = HDMFNumber;
            PositionId = positionid;
            HireDate = hiredate;
            EndHireDate = endhiredate;
            ReHireDate = rehiredate;
            BasicRate = basicrate;
        }
    }
}
