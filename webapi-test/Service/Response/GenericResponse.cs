using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_test.Service.Response
{
    public class GenericResponse<T>: BasicResponse
    {
        public T Data { get; set; }
    }
}