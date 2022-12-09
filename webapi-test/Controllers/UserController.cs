using Microsoft.AspNetCore.Mvc;
using webapi_test.Service.Contract;
using webapi_test.Service.Request;
using webapi_test.Controllers.Model;
using webapi_test.Dto;

namespace webapi_test.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : BaseController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
       _userService = userService;
    }

    [HttpGet(Name = "GetUsers")]
    [Route("/users")]
    public async Task<IActionResult> GetUsers([FromQuery] Guid id)
    {
        var response = await _userService.ReadAllAsync();
        return this.GetSuccessJson(response, response.Data);
    }

    [HttpGet(Name = "GetUser")]
    [Route("/user/{id}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var response = await _userService.ReadAsync(new GenericRequest<Guid>{Data = id});
        return this.GetSuccessJson(response, response.Data);
    }

    [HttpPost(Name = "CreateUser")]
    [Route("/user")]
    public async Task<IActionResult> Create([FromBody] ManageUserRequest model)
    {
        var userDto = new UserDto() {
            Id = Guid.NewGuid(),
            Name = model.Name,
            Email = model.Email,
            Address = model.Address,
            Phone = model.Phone,
            AvatarUrl = model.AvatarUrl,
        };

        var response = await _userService.CreateAsync(new GenericRequest<Dto.UserDto>{Data = userDto});
        return this.GetSuccessJson(response, response.Data);
    }

    [HttpPut(Name = "UpdateUser")]
    [Route("/user")]
    public async Task<IActionResult> Update([FromBody] ManageUserRequest model)
    {
        var userDto = new UserDto() {
            Id = model.Id,
            Name = model.Name,
            Email = model.Email,
            Address = model.Address,
            Phone = model.Phone,
            AvatarUrl = model.AvatarUrl,
        };

        var response = await _userService.UpdateAsync(new GenericRequest<Dto.UserDto>{Data = userDto});
        return this.GetSuccessJson(response, response.Data);
    }

    [HttpDelete(Name = "DeleteUser")]
    [Route("/user")]
    public async Task<IActionResult> Delete([FromBody] BaseRequest<Guid> request)
    {
        await _userService.DeleteAsync(new GenericRequest<Guid>{Data = request.Id});
        return this.GetBasicSuccessJson();
    }
}
