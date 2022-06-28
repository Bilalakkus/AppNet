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

        public Stock Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Stock>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Stock> Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
