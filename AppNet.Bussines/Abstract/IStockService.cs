using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IStockService
    {
        Stock Add(Stock stock);
        Task<Stock> Update(Stock stock);
        Task<bool> Remove(int id);
        Task<ICollection<Stock>> GetAll();
    }
}
