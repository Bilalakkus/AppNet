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

        public Task<Safe> Add(Safe entity)
        {
            return _safeRepository.Add(entity);
        }

        public List<Safe> GetAll()
        {
            return _safeRepository.GetAll();
        }
        public Task<Safe> GetById(int id)
        {
            return _safeRepository.GetById(id);
        }


        public Task<ICollection<Safe>> GetList(Expression<Func<Safe, bool>> expression = null)
        {
            return _safeRepository.GetList(expression);
        }
        public bool Remove(int id)
        {
            bool result = _safeRepository.Remove(id);
            return result;
        }
        public Task<Safe> Update(Safe entity)
        {
            return _safeRepository.Update(entity);
        }
    }
}
