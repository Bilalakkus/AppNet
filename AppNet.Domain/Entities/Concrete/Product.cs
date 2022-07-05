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
        public event StockLowerLimitDelegate StockLowerLimitEvent;
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal UnitPrice { get; set; }
        public short StockMin { get; set; }
        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set { 

                _stock = value;
                if (value <= StockMin && StockLowerLimitEvent != null) StockLowerLimitEvent();
            }
        }
        public void ProductSell(int miktar)
        {
            Stock -= miktar;
        }
        public int CategoryId { get; set; }
        //public Stock Stock { get; set; }

        //public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
