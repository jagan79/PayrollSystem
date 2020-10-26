using AutoMapper;
using Payroll.Application.ViewModels;
using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
