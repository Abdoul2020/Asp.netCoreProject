using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oyabi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0749B41\\SQLEXPRESS; database=nouveaudb; integrated security=true");
        }
        public DbSet<Departmalar> departmalars { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Adminn> adminns { get; set; }
    }
}
