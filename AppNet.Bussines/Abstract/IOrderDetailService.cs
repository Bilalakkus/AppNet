using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IOrderDetailService
    {
        OrderDetail Add(OrderDetail orderDetail);
        Task<OrderDetail> Update(OrderDetail orderDetail);
        Task<bool> Remove(int id);
        Task<ICollection<OrderDetail>> GetAll();
    }
}
