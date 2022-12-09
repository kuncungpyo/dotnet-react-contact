using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Dto;
using webapi_test.Repository.Contract;
using webapi_test.Service.Contract;

namespace webapi_test.Service
{
    public class UserService: BaseService<UserDto, Guid, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository)
            : base(repository)
        {
        }
    }
}