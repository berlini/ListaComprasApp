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
    public class ListaComprasViewModel : NotifyableClass
    {
        private List<ListaCompras> _listaCompras { get; set; }
        public List<ListaCompras> ListaCompras
        {
            get { return _listaCompras; }
            set
            {
                if (value != null)
                {
                    _listaCompras = value;
                    OnPropertyChanged();
                }
            }
        }

        private ListaCompras _listaSelecionada;
        public ListaCompras ListaSelecionada
        {
            get { return _listaSelecionada; }
            set
            {
                if (_listaSelecionada != value)
                {
                    _listaSelecionada = value;
                    OnPropertyChanged();
                }
            }
        }


        public ListaComprasViewModel()
        {
            Inicializa();
        }

        private void Inicializa()
        {
            var repositorio = new ListaComprasRepository();

            ListaCompras = repositorio.LoadAll();
        }

        public void AddListaCompras()
        {
            NavigationService.Navigate(typeof(AddListaComprasPage));
        }

        public void OnListaSelecionadaChanged()
        {
            NavigationService.Navigate(typeof(ListaComprasDetailPage), ListaSelecionada);
        }
    }
}
