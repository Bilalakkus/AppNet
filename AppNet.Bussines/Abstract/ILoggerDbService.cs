using AppNet.Domain.Entities.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface ILoggerDbService
    {
        LoggerDb Add(LoggerDb entity);
        Task<ICollection<LoggerDb>> GetAll();
    }
}
