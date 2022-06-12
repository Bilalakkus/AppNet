using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Exceptions
{
    public class NotEnoughStockException:Exception
    {
        public NotEnoughStockException(string product):base($"{product} ürününün stok durumu yetersiz!")
        {

        }
    }
}
