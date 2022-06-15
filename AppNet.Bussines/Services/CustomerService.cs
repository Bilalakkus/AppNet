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
        public ICollection<Customer> GetList(Expression<Func<Customer, bool>> expression = null)
        {
            return GetList(expression);
        }
        public Task<ICollection<Customer>> GetListAsync(Expression<Func<Customer, bool>> expression = null)
        {
            throw new NotImplementedException();
        }
        public bool RemoveAsync(int id)
        {
            bool result = _customerRepository.RemoveAsync(id);
            return result;
        }
        Task<Customer> IRepository<Customer>.AddAsync(Customer entity)
        {
            return _customerRepository.AddAsync(entity);
        }
        Task<List<Customer>> IRepository<Customer>.GetAllAsync()
        {
            return _customerRepository.GetAllAsync();
        }
        Task<Customer> IRepository<Customer>.GetByIdAsync(int id)
        {
            return _customerRepository.GetByIdAsync(id);
        }
        Task<Customer> IRepository<Customer>.UpdateAsync(Customer entity)
        {
            return _customerRepository.UpdateAsync(entity);
        }
    }
}
