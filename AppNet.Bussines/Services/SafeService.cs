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

        public Safe Add(Safe safe)
        {
           _safeRepository.Add(safe);
            return safe;
        }

        public async Task<ICollection<Safe>> GetAll()
        {
          return  _safeRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _safeRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Safe> Update(Safe safe)
        {
            throw new NotImplementedException();
        }
    }
}
