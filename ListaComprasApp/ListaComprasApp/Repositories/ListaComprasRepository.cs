using ListaComprasApp.Entities;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Repositories
{
    public class ListaComprasRepository
    {
        IMobileServiceTable<ListaCompras> tabela = App.MobileService.GetTable<ListaCompras>();

        public List<ListaCompras> LoadAll()
        {
            var retorno = tabela.ToListAsync();

            return retorno.Result;
        }

        public void Create(ListaCompras lista)
        {
            tabela.InsertAsync(lista);
        }
    }
}
