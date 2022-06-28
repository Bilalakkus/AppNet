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

        public Customer Add(string name)
        {
            Customer customer = new Customer()
            {
                Name = name
            };
            _customerRepository.Add(customer);
            return customer;
        }

        public async Task<ICollection<Customer>> GetAll()
        {
            return _customerRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await _customerRepository.Remove(id);
            return true;
        }

        public Task<Customer> Update(int CustomerID, string NewCustomerName)
        {
            throw new NotImplementedException();
        }
    }
}
