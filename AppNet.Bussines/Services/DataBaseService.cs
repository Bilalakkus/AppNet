using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
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
        public DataBase Add(DataBase entity)
        {
            //DataBase db = new DataBase()
            //{
            //    Name = entity.Name,
            //    Username = entity.Username,
            //    Pasword = entity.Pasword,
            //};
            //_dataBaseRepository.Add(db);
            //return db;
            _dataBaseRepository.Add(entity);
            return entity;
        }
        
        async Task<ICollection<DataBase>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DataBase> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<DataBase>> GetList(Expression<Func<DataBase, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DataBase> Update(DataBase entity)
        {
            throw new NotImplementedException();
        }

        

        public Task<ICollection<DataBase>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
