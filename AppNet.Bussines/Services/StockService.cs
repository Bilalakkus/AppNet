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

        public Task<Stock> AddAsync(Stock entity)
        {
            return _stockRepository.AddAsync(entity);
        }

        public Task<List<Stock>> GetAllAsync()
        {
            return _stockRepository.GetAllAsync();
        }
        public Task<Stock> GetByIdAsync(int id)
        {
            return _stockRepository.GetByIdAsync(id);
        }


        public Task<ICollection<Stock>> GetListAsync(Expression<Func<Stock, bool>> expression = null)
        {
            return _stockRepository.GetListAsync(expression);
        }
        public bool RemoveAsync(int id)
        {
            return _stockRepository.RemoveAsync(id);
        }
        public Task<Stock> UpdateAsync(Stock entity)
        {
            return _stockRepository.UpdateAsync(entity);
        }
    }
}
