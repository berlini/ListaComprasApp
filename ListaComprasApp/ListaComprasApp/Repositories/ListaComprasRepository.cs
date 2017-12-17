using ListaComprasApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Repositories
{
    public class ListaComprasRepository
    {
        public List<ListaCompras> LoadAll()
        {
            using (var context = new ListaComprasContex())
            {
                return context.ListasCompras.Include(lista => lista.Items).ToList();
            }
        }

        public void Create(ListaCompras lista)
        {
            using (var context = new ListaComprasContex())
            {
                context.ListasCompras.Add(lista);
                context.SaveChangesAsync();
            }
        }

        public void Edit(ListaCompras lista)
        {
            using (var context = new ListaComprasContex())
            {
                context.ListasCompras.Update(lista);
                context.SaveChangesAsync();
            }
        }

        public void Delete(ListaCompras lista)
        {
            using (var context = new ListaComprasContex())
            {
                context.ListasCompras.Remove(lista);
                context.SaveChangesAsync();
            }
        }
    }
}
