using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_test.Dto
{
    public abstract class BaseDto<T>
    {
        public T Id {get; set;}
    }
}