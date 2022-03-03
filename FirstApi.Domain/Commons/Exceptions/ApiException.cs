using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Exceptions
{
    class ApiException : ApplicationException
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public ApiException(string message, string statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
