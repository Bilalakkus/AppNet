using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace AppNet.Infrastructer.Logging
{
    public static class FileLogger
    {
        //public string Process { get; set; }
        //public DateTime CreateDate { get; set; } = DateTime.Now;
        //private string moment;
        //private int AddingId;
        //public string Moment
        //{
        //    get { return $"İşlem Tarihi:{CreateDate}; İşlem:{moment};Ekleyen:{AddingId};,"; }
        //}
        public static void AddLog(string moment,int IsItAddId)
        {
            string logText= $"İşlem Tarihi:{DateTime.Now}; İşlem:{moment};Ekleyen:{IsItAddId};,";
            var json = JsonSerializer.Serialize(logText);
            File.WriteAllText("log.txt", json);
        }
    }
}
