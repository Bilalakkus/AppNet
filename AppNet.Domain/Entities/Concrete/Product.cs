using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public short StockMin { get; set; }
        //public Stock Stock { get; set; }

        //public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
