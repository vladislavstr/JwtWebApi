using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Dal.Auth
{
    internal interface IAuthRepository
    {
        Task<List<UserDal>> GetAllUsers();

        Task<UserDal> GetUserById(int id);

        Task<UserDal> AddUser(UserDal user);
    }
}
