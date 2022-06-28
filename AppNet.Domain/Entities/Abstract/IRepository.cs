using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Remove(int id);
        Task<TEntity> GetById(int id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> Update(int id, TEntity entity);
    }
}
