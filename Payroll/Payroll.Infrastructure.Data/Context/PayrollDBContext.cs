using Microsoft.EntityFrameworkCore;
using Payroll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Infrastructure.Data.Context
{
    public class PayrollDBContext : DbContext
    {
        public PayrollDBContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
