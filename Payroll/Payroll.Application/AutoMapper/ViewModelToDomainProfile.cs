using AutoMapper;
using Payroll.Application.ViewModels;
using Payroll.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<EmployeeViewModel, CreateEmployeeCommand>()
                .ConstructUsing(c => new CreateEmployeeCommand (
                    c.IDNumber,
                    c.LastName,
                    c.FirstName,
                    c.MiddleName,
                    c.SSSNumber,
                    c.PhilHealthNumber,
                    c.HDMFNumber,
                    c.PositionId,
                    c.HireDate,
                    c.EndHireDate,
                    c.ReHireDate,
                    c.BasicRate
                    ));
        }
    }
}
