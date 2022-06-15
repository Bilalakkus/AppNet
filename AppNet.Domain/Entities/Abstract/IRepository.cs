using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Abstract
{
    public interface IRepository<TEntity> 
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        bool RemoveAsync(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<ICollection<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression=null);
    }
}
