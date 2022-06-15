using Microsoft.EntityFrameworkCore;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=BDSchedBrain; Integrated Security=SSPI");
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
    }
}
