using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class DataBase:BaseEntity
    {
        public int DataBaseId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }
        public string Server { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
