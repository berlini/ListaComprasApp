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

        public async void Create(Item item)
        {
            using (var context = new ListaComprasContex())
            {
                context.Items.Add(item);
                await context.SaveChangesAsync();
            }
        }

        public async void Edit(Item item)
        {
            using (var context = new ListaComprasContex())
            {
                context.Items.Update(item);
                await context.SaveChangesAsync();
            }
        }
    }
}
