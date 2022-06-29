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

        public Product Add(Product product)
        {
            _productRepository.Add(product);
            return product;
        }

        public async Task<ICollection<Product>> GetAll()
        {
           return _productRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _productRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Product> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
