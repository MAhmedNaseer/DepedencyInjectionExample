using DepedencyInjectionExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepedencyInjectionExample.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        IQueryable<Employee> All { get; }
        Employee Find(int? id);
        void InsertOrUpdate(Employee employee);
        void Delete(int id);
        void Save();
    }
}