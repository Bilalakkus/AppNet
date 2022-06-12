using AppNet.Bussines.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Validation
{
    public static class Validations
    {
        public static void TcInCorrect(this string tc)
        {
            if (!tc.TcVerify())
                throw new ArgumentException(tc, $"{tc} Hatalı!");
        }
        public static void NullOrEmpty(this string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(paramName, $"{paramName} değeri boş yada null  olamaz.");
        }
        public static void Zero(this double value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
        public static void Zero(this ushort value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
        public static void Zero(this int value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
        public static void IsNotNegatif(this int value, string paramName)
        {
            if (0 > value)
                throw new ArgumentException(paramName, $"{paramName} değeri negatif olamaz.");
        }
    }
}
