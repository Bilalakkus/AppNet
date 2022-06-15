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
        public Task<Supplier> AddAsync(Supplier entity)
        {
            return _suplierRepository.AddAsync(entity);
        }
        public Task<List<Supplier>> GetAllAsync()
        {
            return _suplierRepository.GetAllAsync();
        }
        public Task<Supplier> GetByIdAsync(int id)
        {
            return _suplierRepository.GetByIdAsync(id);
        }
        public Task<ICollection<Supplier>> GetListAsync(Expression<Func<Supplier, bool>> expression = null)
        {
            return _suplierRepository.GetListAsync(expression);
        }
        public bool RemoveAsync(int id)
        {
            return _suplierRepository.RemoveAsync(id);
        }
        public Task<Supplier> UpdateAsync(Supplier entity)
        {
            return _suplierRepository.UpdateAsync(entity);
        }
    }
}
