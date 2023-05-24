using EServicesAPI.Models;
using Shared;

namespace EServicesAPI.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        UserDto? Login(UserDto userDto);
    }
}
