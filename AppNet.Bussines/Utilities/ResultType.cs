using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Utilities
{
    public class ResultType
    {
        public bool isError;
        public string errorMessage;
        public object data;
        public ResultType(bool isError):this(isError,null,null)
        {

        }
        public ResultType(bool isError, string errorMessage):this(isError,errorMessage,null)
        {

        }
        public ResultType(bool isError, string errorMessage,object data)
        {
            this.isError = isError;
            this.errorMessage = errorMessage;
            this.data = data;
        }
    }
}
