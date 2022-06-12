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
    public class StockService : IRepository<Stock>,IStockService
    {
        public Stock Add(Stock entity)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stock GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Stock> GetList(Expression<Func<Stock, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
