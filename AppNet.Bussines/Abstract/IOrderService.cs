using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IOrderService
    {
        Order Add(Order order);
        Task<Order> Update(Order order);
        Task<bool> Remove(int id);
        Task<ICollection<Order>> GetAll();
    }
}
