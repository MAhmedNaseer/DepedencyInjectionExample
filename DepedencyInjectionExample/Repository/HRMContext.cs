using DepedencyInjectionExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepedencyInjectionExample.Repository
{
    public class HRMContext : DbContext
    {
        public HRMContext()
            : base("DepedencyInjectionExample")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}