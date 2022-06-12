using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public abstract class Customer : BaseEntity, IEntity
    {
        public int CustomerId { get; set; }
       
        public string Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Stock> Stocks { get; set; }=new List<Stock>();
        //public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Safe> Safes { get; set; } = new List<Safe>();

    }
}
