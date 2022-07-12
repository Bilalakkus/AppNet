using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Services
{
    public class OrderDetailServices : IOrderDetailService
    {
        private readonly IRepository<OrderDetail> _repository;
        public OrderDetailServices(IRepository<OrderDetail> repository)
        {
            this._repository = repository;
        }
        public OrderDetail Add(OrderDetail orderDetail)
        {
            _repository.Add(orderDetail);
            return orderDetail;
        }

        public async Task<ICollection<OrderDetail>> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await _repository.Remove(id);
            return true;
        }

        public async Task<OrderDetail> Update(OrderDetail orderDetail)
        {
            _repository.Update(orderDetail);
            return orderDetail;
        }
    }
}
