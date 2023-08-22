using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Dal.Auth
{
    public class AuthContext : DbContext
    {
        public DbSet<UserDal> Users { get; set; }

        public DbSet<UserStateDal> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("Host=localhost;Port=5432;Database=JwtDb;Username=postgres;Password=qwe!23"));
        }
    }
}
