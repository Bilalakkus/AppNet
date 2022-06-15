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

        Task<Customer> IRepository<Customer>.Add(Customer entity)
        {
            return _customerRepository.Add(entity);
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        Task<Customer> IRepository<Customer>.GetById(int id)
        {
            return _customerRepository.GetById(id);
        }
        Task<Customer> IRepository<Customer>.Update(Customer entity)
        {
            return _customerRepository.Update(entity);
        }

        public bool Remove(int id)
        {
            return _customerRepository.Remove(id);
        }

        Task<ICollection<Customer>> IRepository<Customer>.GetList(Expression<Func<Customer, bool>> expression)
        {
            return _customerRepository.GetList(expression);
        }
    }
}
