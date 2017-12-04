using ListaComprasApp.Entities;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Repositories
{
    public class ItemRepository
    {
        IMobileServiceTable<Item> tabela = App.MobileService.GetTable<Item>();

        public List<Item> LoadAll()
        {
            var retorno = tabela.ToListAsync();

            return retorno.Result;
        }

        public void Create(Item item)
        {
            tabela.InsertAsync(item);
        }
    }
}
