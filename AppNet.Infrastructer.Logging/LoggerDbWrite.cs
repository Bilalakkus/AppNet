using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Logging
{
    public class LoggerDbWrite
    {
        private readonly ILoggerDbService _loggerDbService;
        public LoggerDbWrite(ILoggerDbService loggerDbService)
        {
            this._loggerDbService = loggerDbService;
        }
        public void AddLogDb(string moment, int AddingId)
        {
            LoggerDb loggerDb = new LoggerDb 
            { 
                AddingId= AddingId,
                CreateDate= DateTime.Now,
                Moment=moment,
            };
            _loggerDbService.Add(loggerDb);
        }
    }
}
