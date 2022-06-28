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

        public Safe Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Safe>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Safe> Update(Safe safe)
        {
            throw new NotImplementedException();
        }
    }
}
