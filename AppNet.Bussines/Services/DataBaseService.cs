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
            this._dataBaseRepository=repository;
        }

        public DataBase Add(string name)
        {
            DataBase dataBase = new DataBase()
            {
                Name = name
            };
            _dataBaseRepository.Add(dataBase);
            return dataBase;
        }

        public async Task<ICollection<DataBase>> GetAll()
        {
            return _dataBaseRepository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await _dataBaseRepository.Remove(id);
            return true;
        }

        public Task<DataBase> Update(int DatabaseID, string NewDatabaseName)
        {
            throw new NotImplementedException();
        }
    }
}
