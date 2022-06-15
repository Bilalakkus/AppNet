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
        private readonly IRepository<Order> _orderService;
        public OrderService(IRepository<Order> orderRepository)
        {
            this._orderService=orderRepository;
        }
        public Task<Order> AddAsync(Order entity)
        {
            return _orderService.AddAsync(entity);
        }
        public Task<List<Order>> GetAllAsync()
        {
            return _orderService.GetAllAsync();
        }
        public Task<Order> GetByIdAsync(int id)
        {
           return _orderService.GetByIdAsync(id);
        }
        public Task<ICollection<Order>> GetListAsync(Expression<Func<Order, bool>> expression = null)
        {
            return _orderService.GetListAsync(expression);
        }
        public bool RemoveAsync(int id)
        {
           bool result = _orderService.RemoveAsync(id);
            return result;
        }
        public Task<Order> UpdateAsync(Order entity)
        {
            return _orderService.UpdateAsync(entity);
        }
    }
}
