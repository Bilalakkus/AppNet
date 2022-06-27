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
        public Order Add(Order entity)
        {
            return _orderService.Add(entity);
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        //public List<Order> GetAll()
        //{
        //    return _orderService.GetAll();
        //}
        public Task<Order> GetById(int id)
        {
           return _orderService.GetById(id);
        }
        public Task<ICollection<Order>> GetList(Expression<Func<Order, bool>> expression = null)
        {
            return _orderService.GetList();
        }

        public Task<ICollection<Order>> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
           bool result = _orderService.Remove(id);
            return result;
        }
        public Task<Order> Update(Order entity)
        {
            return _orderService.Update(entity);
        }

        ICollection<Order> IRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
