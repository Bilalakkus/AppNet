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
    public class SafeService : ISafeService
    {
        private readonly IRepository<Safe> _safeRepository;
        public SafeService(IRepository<Safe> safeRepository)
        {
            _safeRepository=safeRepository;
        }

        public Task<Safe> AddAsync(Safe entity)
        {
            return _safeRepository.AddAsync(entity);
        }

        public Task<List<Safe>> GetAllAsync()
        {
            return _safeRepository.GetAllAsync();
        }
        public Task<Safe> GetByIdAsync(int id)
        {
            return _safeRepository.GetByIdAsync(id);
        }


        public Task<ICollection<Safe>> GetListAsync(Expression<Func<Safe, bool>> expression = null)
        {
            return _safeRepository.GetListAsync(expression);
        }
        public bool RemoveAsync(int id)
        {
            bool result = _safeRepository.RemoveAsync(id);
            return result;
        }
        public Task<Safe> UpdateAsync(Safe entity)
        {
            return _safeRepository.UpdateAsync(entity);
        }
    }
}
