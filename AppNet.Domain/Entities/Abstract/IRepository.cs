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
        public Task<TEntity> Add(TEntity entity);
        public Task<TEntity> Update(TEntity entity);
        public bool Remove(int id);
        public Task<TEntity> GetById(int id);
        public List<TEntity> GetAll();
        public Task<ICollection<TEntity>> GetList(Expression<Func<TEntity, bool>> expression=null);
    }
}
