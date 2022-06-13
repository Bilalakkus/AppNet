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
    public class SafeService : IRepository<Safe>,ISafeService
    {
        public Safe Add(Safe entity)
        {
            throw new NotImplementedException();
        }

        public List<Safe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Safe GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Safe> GetList(Expression<Func<Safe, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Safe Update(Safe entity)
        {
            throw new NotImplementedException();
        }
    }
}
