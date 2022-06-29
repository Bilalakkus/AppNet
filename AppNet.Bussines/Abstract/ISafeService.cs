using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface ISafeService
    {
        Safe Add(Safe safe);
        Task<Safe> Update(Safe safe);
        Task<bool> Remove(int id);
        Task<ICollection<Safe>> GetAll();
    }
}
