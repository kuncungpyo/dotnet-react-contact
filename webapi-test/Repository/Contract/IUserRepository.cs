using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Dto;

namespace webapi_test.Repository.Contract
{
    public interface IUserRepository:IBaseRepository<UserDto>
    {   
    }
}