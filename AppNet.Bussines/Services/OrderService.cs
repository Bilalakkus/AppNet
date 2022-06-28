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
        private readonly IRepository<Order> repository;
        public OrderService(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        public Order Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
