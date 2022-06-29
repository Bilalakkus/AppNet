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

        public Supplier Add(Supplier supplier)
        {
            _suplierRepository.Add(supplier);
            return supplier;
        }

        public async Task<ICollection<Supplier>> GetAll()
        {
            return _suplierRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _suplierRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Supplier> Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
