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
        public string process { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        private string moment;

        public string Moment
        {
            get { return $"İşlem Tarihi:{CreateDate}; İşlem:{moment};,"; }
        }

        public  void AddLog( string movement)
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(Constants.LOG_FILE_PATH, json);
        }
    }
}
