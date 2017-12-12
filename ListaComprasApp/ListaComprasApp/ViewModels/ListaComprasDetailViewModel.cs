using ListaComprasApp.Entities;
using ListaComprasApp.Pages;
using ListaComprasApp.Repositories;
using ListaComprasApp.Services;
using ListaComprasApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.ViewModels
{
    public class ListaComprasDetailViewModel : NotifyableClass
    {
        ListaComprasRepository Repositorio;

        private ListaCompras _listaCompras;
        public ListaCompras ListaCompras
        {
            get { return _listaCompras; }
            set
            {
                _listaCompras = value;
                OnPropertyChanged();
            }
        }

        public ListaComprasDetailViewModel()
        {
            Repositorio = new ListaComprasRepository();
        }

        public void AdicionaItem()
        {

        }

        public void Salvar()
        {
            Repositorio.Edit(ListaCompras);

            NavigationService.Navigate(typeof(ListaComprasPage));
        }

        public void Excluir()
        {
            Repositorio.Delete(ListaCompras);

            NavigationService.Navigate(typeof(ListaComprasPage));
        }

    }
}
