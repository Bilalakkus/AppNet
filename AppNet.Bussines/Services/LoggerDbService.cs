using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppNet.Bussines.Services
{
    public class LoggerDbService : ILoggerDbService
    {
        private readonly IRepository<LoggerDb> _repository;
        public LoggerDbService(IRepository<LoggerDb> repository)
        {
            this._repository = repository;
        }
        public LoggerDb Add(LoggerDb entity)
        {
           _repository.Add(entity);
            return entity;
        }

        public Task<ICollection<LoggerDb>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
