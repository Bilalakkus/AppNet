using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface ICategoriService
    {
        Category Add(string name);
        Task<Category> Update(int CategoryID, string NewCategoryName);
        Task<bool> Remove(int id);
        Task<ICollection<Category>> GetAll();
    }
}
