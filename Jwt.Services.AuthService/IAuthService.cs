using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Services.AuthService
{
    internal interface IAuthService
    {
        Task<List<User>> GetAllUsers();

        Task<User> GetUserById(int id);

        Task<User> AddUser(User user);
    }
}
