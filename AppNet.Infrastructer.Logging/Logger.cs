using AppNet.Bussines.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace AppNet.Infrastructer.Logging
{
    public class Logger
    {
        public string Process { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        private string moment;
        private int AddingId;
        public string Moment
        {
            get { return $"İşlem Tarihi:{CreateDate}; İşlem:{moment};Ekleyen:{AddingId};,"; }
        }
        public void AddLog( string movement,int IsItPassive)
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(Constants.LOG_FILE_PATH, json);
        }
    }
}
