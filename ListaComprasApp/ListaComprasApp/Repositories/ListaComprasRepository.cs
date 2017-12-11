using ListaComprasApp.Entities;
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
                return context.ListasCompras.ToList();
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
    }
}
