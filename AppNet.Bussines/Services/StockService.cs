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
    public class StockService : IStockService
    {
        private readonly IRepository<Stock> _stockRepository;
        public StockService(IRepository<Stock> stokRepository)
        {
            _stockRepository= stokRepository;
        }

        public Stock Add(Stock entity)
        {
            return _stockRepository.Add(entity);
        }

        //public List<Stock> GetAll()
        //{
        //    return _stockRepository.GetAll();
        //}
        public Task<Stock> GetById(int id)
        {
            return _stockRepository.GetById(id);
        }


        public Task<ICollection<Stock>> GetList(Expression<Func<Stock, bool>> expression = null)
        {
            return _stockRepository.GetList();
        }

        public Task<ICollection<Stock>> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            return _stockRepository.Remove(id);
        }
        public Task<Stock> Update(Stock entity)
        {
            return _stockRepository.Update(entity);
        }
    }
}
