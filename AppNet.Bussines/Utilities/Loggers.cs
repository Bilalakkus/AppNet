using AppNet.Bussines.Abstract;
using AppNet.Bussines.Services;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain
{
    public static class Loggers
    {
        public static void LoggerWrite(string moment, int addingId)
        {
            AfterGetLog logg = FileLogger.AddLog;
            logg += LoggerDbWrite.AddLogDb;
            logg.Invoke(moment,addingId);
        }
    }
}
