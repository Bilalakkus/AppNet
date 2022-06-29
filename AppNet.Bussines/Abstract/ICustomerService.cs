using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines
{
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        Task<Customer> Update(Customer customer);
        Task<bool> Remove(int id);
        Task<ICollection<Customer>> GetAll();
    }
}
