using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class UserResponse
    {
        public List<UserDto> UserDtos { get; set; }
        public UserDto UserDto { get; set; }
    }
}
