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
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> AddAsync(Product entity)
        {
            return _productRepository.AddAsync(entity);
        }
        public Task<List<Product>> GetAllAsync()
        {
            return _productRepository.GetAllAsync();
        }
        public Task<Product> GetByIdAsync(int id)
        {
            return _productRepository.GetByIdAsync(id);
        }
        public Task<ICollection<Product>> GetListAsync(Expression<Func<Product, bool>> expression = null)
        {
            return GetListAsync(expression);
        }
        public bool RemoveAsync(int id)
        {
            bool result = _productRepository.RemoveAsync(id);
            return result;
        }

        public Product SearchProductName(string name)
        {
            //return _productRepository.GetAllAsync().FirstOrDefault(p=>p.ProductName==name);
            throw new NotImplementedException();
        }
        public Task<Product> UpdateAsync(Product entity)
        {
            return _productRepository.UpdateAsync(entity);
        }
    }
}
