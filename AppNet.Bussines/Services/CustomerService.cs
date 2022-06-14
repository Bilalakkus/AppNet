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
        public Customer Add(Customer entity)
        {
            return _customerRepository.Add(entity);
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
           return _customerRepository.GetById(id);
        }

        public ICollection<Customer> GetList(Expression<Func<Customer, bool>> expression = null)
        {
            return GetList(expression);
        }

        public bool Remove(int id)
        {
            bool result = _customerRepository.Remove(id);
            return result;
        }

        public Customer Update(Customer entity)
        {
            return _customerRepository.Update(entity);
        }
    }
}
