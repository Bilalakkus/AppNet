using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Services
{
    public class DataBaseService : IDatabaseService
    {
        private readonly IRepository<DataBase> _dataBaseRepository;
        public DataBaseService(IRepository<DataBase> repository)
        {
            this._dataBaseRepository = repository;
        }

        public DataBase Add(DataBase dataBase)
        {
            _dataBaseRepository.Add(dataBase);
            return dataBase;
        }

        public async Task<ICollection<DataBase>> GetAll()
        {
            return _dataBaseRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                _dataBaseRepository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<DataBase> Update(DataBase dataBase)
        {
            throw new NotImplementedException();
        }
    }
}
