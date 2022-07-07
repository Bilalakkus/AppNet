using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Notification
{
    public class Telegram
    {
        public static void LoggTelegram(string moment, int AddingId)
        {
            string message = $"İşlem:{moment}, tarih:{DateTime.Now}, İşlemi Yapan:{AddingId}";
        }
    }
}
