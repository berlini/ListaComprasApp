using ListaComprasApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Repositories
{
    public class ItemRepository
    {
        public List<Item> LoadAll()
        {
            using (var context = new ListaComprasContex())
            {
                return context.Items.ToList();
            }
        }

        public void Create(Item item)
        {
            using (var context = new ListaComprasContex())
            {
                context.Items.Add(item);
                context.SaveChangesAsync();
            }
        }
    }
}
