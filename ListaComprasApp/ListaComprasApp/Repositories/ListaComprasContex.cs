using ListaComprasApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Repositories
{
    public class ListaComprasContex : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ListaCompras> ListasCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=listacompras.db");
        }
    }
}
