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
using Windows.UI.Xaml.Controls;

namespace ListaComprasApp.ViewModels
{
    public class AddItemViewModel : NotifyableClass
    {
        ItemRepository ItemRepositorio;
        ListaComprasRepository ListaComprasRepositorio;

        public ListaCompras ListaCompras;

        private Item _item;
        public Item Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        public AddItemViewModel()
        {
            ItemRepositorio = new ItemRepository();
            ListaComprasRepositorio = new ListaComprasRepository();

            Item = new Item
            {
                Concluido = false,
                Quantidade = 0
            };
        }

        public async void Salvar()
        {
            ContentDialog salvarDialog = new ContentDialog
            {
                Title = "Deseja salvar as alterações?",
                CloseButtonText = "Não",
                PrimaryButtonText = "Sim"
            };

            ContentDialogResult resultado = await salvarDialog.ShowAsync();

            if (resultado == ContentDialogResult.Primary)
            {
                ItemRepositorio.Create(Item);

                ListaCompras.Items.Add(Item);
                ListaComprasRepositorio.Edit(ListaCompras);
            }

            NavigationService.Navigate(typeof(ListaComprasDetailPage), ListaCompras);
        }
    }
}
