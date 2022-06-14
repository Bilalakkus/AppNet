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
    public class SuplierService : ISuplierService
    {
        private readonly IRepository<Supplier> _suplierRepository;
        public SuplierService(IRepository<Supplier> suplplierRepository)
        {
            _suplierRepository=suplplierRepository;
        }

        public Supplier Add(Supplier entity)
        {
            return _suplierRepository.Add(entity);
        }

        public List<Supplier> GetAll()
        {
            return _suplierRepository.GetAll();
        }

        public Supplier GetById(int id)
        {
            return _suplierRepository.GetById(id);
        }

        public ICollection<Supplier> GetList(Expression<Func<Supplier, bool>> expression = null)
        {
            return _suplierRepository.GetList(expression);
        }

        public bool Remove(int id)
        {
            return _suplierRepository.Remove(id);
        }

        public Supplier Update(Supplier entity)
        {
            return _suplierRepository.Update(entity);
        }
    }
}
