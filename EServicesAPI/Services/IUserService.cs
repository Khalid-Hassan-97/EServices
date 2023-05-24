using EServicesAPI.Models;
using Shared;

namespace EServicesAPI.Services
{
    public interface IUserService
    {
        List<UserDto> GetUsers();
        UserDto? Login(UserDto userDto);
    }
}
