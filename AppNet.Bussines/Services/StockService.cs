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

        public Stock Add(Stock stock)
        {
            _stockRepository.Add(stock);
            return stock;
        }

        public async Task<ICollection<Stock>> GetAll()
        {
            return _stockRepository.GetAll().ToList();
            
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _stockRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Stock> Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
