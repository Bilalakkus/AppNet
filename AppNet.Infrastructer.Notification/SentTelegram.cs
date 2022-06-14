using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace AppNet.Infrastructer.Notification
{

    public class SentTelegram
    {
        
        public TelegramBotClient bot = new TelegramBotClient("5585107930:AAEx4KYh1dm7U1ymrjpGV4WhzvrTfManAPo");
         
        public void TelegramMesjGonder(string message)
        {
            bot.SendTextMessageAsync(657385223, message);
        }
    }
}
