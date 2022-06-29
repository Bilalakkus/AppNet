using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface ISuplierService 
    {
        Supplier Add(Supplier supplier);
        Task<Supplier> Update(Supplier supplier);
        Task<bool> Remove(int id);
        Task<ICollection<Supplier>> GetAll();
    }
}
