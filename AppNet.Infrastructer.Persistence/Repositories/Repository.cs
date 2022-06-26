using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppNetDbContext context;
        private readonly IRepository<TEntity> repository;
        public Repository(AppNetDbContext context, IRepository<TEntity> repository)
        {
            this.context = context;
            this.repository=repository;
        }
        public  TEntity Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity;
            //throw new NotImplementedException();
        }
        public  List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ICollection<TEntity>> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            throw new NotImplementedException();
        }
        public Task<ICollection<TEntity>> GetList()
        {
            throw new NotImplementedException();
        }
        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
