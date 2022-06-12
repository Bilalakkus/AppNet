using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Utilities
{
    public static class TcIsItCorrectExtension
    {
        public static bool TcVerify(this string tc)
        {
            if (tc.Length==11)
            {
                //diğer tc algoritmaları kontrol edilecek
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
