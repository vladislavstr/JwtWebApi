using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Dal.Auth
{
    public class UserDal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [ForeignKey(nameof(UserGroupId))]
        public UserGroupDal UserGroup { get; set; }

        public int UserGroupId { get; set; }

        [Required]
        [ForeignKey(nameof(UserStateId))]
        public UserStateDal UserState { get; set; }

        public int UserStateId { get; set; }
    }
}
