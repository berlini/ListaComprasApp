using ListaComprasApp.Entities;
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

    }
}
