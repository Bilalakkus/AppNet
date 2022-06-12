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
    public class SuplierService : IRepository<Supplier>,ISuplierService
    {
        public Supplier Add(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public Supplier GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Supplier> GetList(Expression<Func<Supplier, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
