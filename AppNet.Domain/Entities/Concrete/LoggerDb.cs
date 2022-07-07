using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class LoggerDb:BaseEntity
    {
        public int LoggerDbId { get; set; }
        public string Moment { get; set; }
        public DateTime CDate { get; set; }
    }
}
