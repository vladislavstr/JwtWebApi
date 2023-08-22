using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Services.AuthService
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public UserGroup UserGroup { get; set; }

        public int UserGroupId { get; set; }

        public UserState UserState { get; set; }

        public int UserStateId { get; set; }
    }
}
