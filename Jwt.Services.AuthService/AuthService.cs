using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Services.AuthService
{
    internal class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IAuyhRepository _userRepository;
    }
}
