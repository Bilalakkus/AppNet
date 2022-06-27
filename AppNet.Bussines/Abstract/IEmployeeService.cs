using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IEmployeeService:IRepository<Employee>
    {
        Employee SearchName(string name);
        Employee SearchLastName(string lastName);
        Employee SearchTc(string tc);
        List<Employee> SearchAll();
        //Task<ICollection<Employee>> GetAll();

    }
}
