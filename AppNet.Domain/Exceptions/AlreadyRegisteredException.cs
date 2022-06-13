using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Exceptions
{
    public class AlreadyRegisteredException:Exception
    {
        public AlreadyRegisteredException(string value):base($"{value} zaten kayıtlı!")
        {

        }
    }
}
