using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Exceptions
{
    public class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string value):base($"{value} bulunamadı!")
        {

        }
    }
}
