using GorevAtama.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Data.Concrete
{
    public class GorevAtamaContext : DbContext
    {
        public DbSet<Personal> Personels { get; set; }
        public DbSet<Islem> Islems { get; set; }
        public DbSet<Rol> Rols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=GorevAtamaDB; Trusted_Connection=True; TrustServerCertificate=True");
        }


    }
}
