using AppNet.Bussines;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerService(IRepository<Customer> customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public Customer Add(Customer customer)
        {
           _customerRepository.Add(customer);
            return customer;
        }

        public async Task<ICollection<Customer>> GetAll()
        {
          return _customerRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _customerRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Customer> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
