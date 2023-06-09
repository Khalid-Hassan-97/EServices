﻿using EServicesAPI.Models;
using Shared;

namespace EServicesAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserDto> GetUsers()
        {
            var users = _dataContext.Users.ToList();
            var userDtos = users.Select(MiniAutoMapper).ToList();
            return userDtos;
        }

        public UserDto? Login(UserDto userDto)
        {
            var user = _dataContext.Users.FirstOrDefault(u => u.Username == userDto.Username && u.PasswordHash == Base64Converter.Base64Encode(userDto.Password));

            if (user == null)
            {
                return null;
            }

            var userDto_ = MiniAutoMapper(user);

            return userDto_;
        }

        private UserDto MiniAutoMapper(User user)
        {
            var userDto = new UserDto()
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserType = user.UserType,
                Name = user.Name,
            };

            return userDto;
        }
    }
}
