using AppNet.Bussines.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class DatabaseInformation
    {
        public string Server { get; set; }
        public string Db { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        private string conStr;

        public string ConStr
        {
            get { return $"Server={Server};Database={Db};User Id={User};Password={Pass}"; }

        }
        public void Save()
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(Constants.DATABASE, json);

        }

        public static DatabaseInformation Load()
        {
            if (File.Exists(Constants.DATABASE))
            {
                var json = File.ReadAllText(Constants.DATABASE);
                return JsonSerializer.Deserialize<DatabaseInformation>(json);

            }

            File.WriteAllText(Constants.DATABASE, "{}");
            return null;


        }
    }
}
