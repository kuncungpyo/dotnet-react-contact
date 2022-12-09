using webapi_test.Dto;

namespace webapi_test.Service.Contract
{
    public interface IUserService: IBaseService<UserDto, Guid>
    {
        
    }
}