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
            throw new NotImplementedException();
        }

        //public List<Supplier> GetAll()
        //{
        //    return _suplierRepository.GetAll();
        //}
        public Task<Supplier> GetById(int id)
        {
            return _suplierRepository.GetById(id);
        }
        public Task<ICollection<Supplier>> GetList(Expression<Func<Supplier, bool>> expression = null)
        {
            return _suplierRepository.GetList();
        }

        public Task<ICollection<Supplier>> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            return _suplierRepository.Remove(id);
        }
        public Task<Supplier> Update(Supplier entity)
        {
            return _suplierRepository.Update(entity);
        }

        ICollection<Supplier> IRepository<Supplier>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
