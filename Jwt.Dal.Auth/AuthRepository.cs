using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Dal.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private static AuthContext _context;

        public AuthRepository(AuthContext context)
        {
            _context = context;
        }
        public async Task<List<UserDal>> GetAllUsers()
        {
            var result = new List<UserDal>();

            result = _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public async Task<UserDal> GetUserById(int id)
        {
            return _context.Users
           .Include(u => u.UserGroup)
           .Include(u => u.UserState)
           .Single(u => u.Id == id);
        }

        public async Task<UserDal> AddUser(UserDal user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return _context.Users
                .Include(u => u.UserGroup)
                .Include(u => u.UserState)
                .Single(u => u.Id == user.Id);
        }
    }
}
