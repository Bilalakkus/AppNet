﻿using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System.Linq.Expressions;

namespace AppNet.Bussines.Concrete
{
    public class CategoriService : ICategoriService
    {
        private readonly IRepository<Category> repository;
        public CategoriService(IRepository<Category> repository)
        {
            this.repository = repository;
        }
       
        public Category GetCategory(string name)
        {
            //var result = repository.GetAllAsync();
            throw new NotImplementedException();
        }
        public Category Add(Category entity)
        {
            // validations
            return repository.Add(entity);
        }

        //public List<Category> GetAll()
        //{
        //    return repository.GetAll();
        //}

       public  Task<Category> GetById(int id)
        {
            return repository.GetById(id);
        }

        async Task<ICollection<Category>> GetList()
        {
            //return repository.GetList().To;

            throw new NotImplementedException();
        }
        public Task<Category> Update(Category entity)
        {
            return repository.Update(entity);
        }
        public bool Remove(int id)
        {
            return repository.Remove(id);
        }
        Task<ICollection<Category>> IRepository<Category>.GetList()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        ICollection<Category> IRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
