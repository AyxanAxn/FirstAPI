using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Response
{
    class ApiResponse<T> where T : class
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public ApiResponse(T data)
        {
            Data = data;
            ErrorMessage = "";
            Success = true;
        }
        public ApiResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Success = false;
        }
    }
}