﻿using AppNet.Bussines.Abstract;
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
        public Product Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public ICollection<Product> GetList(Expression<Func<Product, bool>> expression = null)
        {
            return GetList(expression);
        }

        public bool Remove(int id)
        {
           bool result = _productRepository.Remove(id);
            return result;
        }

        public Product SearchProductName(string name)
        {
            return _productRepository.GetAll().FirstOrDefault(p=>p.ProductName==name);
        }

        public Product Update(Product entity)
        {
            return _productRepository.Update(entity);
        }
    }
}
