using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AppNet.Bussines.Abstract
{
    public interface IDatabaseService 
    {
        DataBase Add(DataBase dataBase);
        Task<DataBase> Update(DataBase dataBase);
        Task<bool> Remove(int id);
        Task<ICollection<DataBase>> GetAll();
    }
}
