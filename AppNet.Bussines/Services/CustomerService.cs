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

        Customer Add(Customer entity)
        {
            return _customerRepository.Add(entity);
        }
        //public List<Customer> GetAll()
        //{
        //    return _customerRepository.GetAll();
        //}
        Customer GetById(int id)
        {
            return GetById(id);
        }
        Customer Update(Customer entity)
        {
            return Update(entity);
        }

        public bool Remove(int id)
        {
            return _customerRepository.Remove(id);
        }

        ICollection<Customer> GetList(Expression<Func<Customer, bool>> expression)
        {
            return GetList(expression);
        }

        Customer IRepository<Customer>.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        Task<Customer> IRepository<Customer>.Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        Task<Customer> IRepository<Customer>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        async Task<ICollection<Customer>> IRepository<Customer>.GetList()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Customer>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
