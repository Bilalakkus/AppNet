using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IEmployeeService//:IRepository<Employee>
    {
        Employee Add(Employee employee);
        Task<Employee> Update(Employee employee);
        bool Remove(int id);
        Task<ICollection<Employee>> GetAll();

    }
}
