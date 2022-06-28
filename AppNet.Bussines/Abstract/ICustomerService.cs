using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines
{
    public interface ICustomerService//:IRepository<Customer>
    {
        Customer Add(string name);
        Task<Customer> Update(int CustomerID, string NewCustomerName);
        Task<bool> Remove(int id);
        Task<ICollection<Customer>> GetAll();
    }
}
