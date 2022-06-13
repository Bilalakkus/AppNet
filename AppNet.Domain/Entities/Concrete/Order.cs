using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int OrderId { get; set; }

        public short Qantity { get; set; }
        public decimal Total { get; set; }
        //public Customer Customer { get; set; }
        //public Product Product { get; set; }
    }
}
