using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Dal.Auth
{
    public class UserStateDal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Code { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string? Description { get; set; }
    }
}
