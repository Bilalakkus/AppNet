using AppNet.Bussines.Abstract;
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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;
        public OrderService(IRepository<Order> repository)
        {
            this._repository = repository;
        }

        public Order Add(Order order)
        {
            _repository.Add(order);
            return order;
        }

        public async Task<ICollection<Order>> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _repository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Order> Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
