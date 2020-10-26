﻿using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public string IDNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SSSNumber { get; set; }
        public string PhilHealthNumber { get; set; }
        public string HDMFNumber { get; set; }
        public string PositionId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime EndHireDate { get; set; }
        public DateTime ReHireDate { get; set; }
        public double BasicRate { get; set; }
        
    }
}
