using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Safe : BaseEntity
    {
        public int SafeId { get; set; }
        public SafeType Type { get; set; }
        public Customer Customer { get; set; }
        public decimal Total { get; set; }
        public string Explanation { get; set; }
    }
    public enum SafeType 
    { 
        input=1,
        output=2,
    }
}
