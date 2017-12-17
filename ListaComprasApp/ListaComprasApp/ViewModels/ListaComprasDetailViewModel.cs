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

        private Item _itemSelecionado;
        public Item ItemSelecionado
        {
            get { return _itemSelecionado; }
            set
            {
                _itemSelecionado = value;
                OnPropertyChanged();
            }
        }

        public ListaComprasDetailViewModel()
        {
            Repositorio = new ListaComprasRepository();
        }

        public void AdicionaItem()
        {
            NavigationService.Navigate(typeof(AddItemPage), ListaCompras);
        }

        public async void Salvar()
        {
            ContentDialog excluirDialog = new ContentDialog
            {
                Title = "Deseja salvar as alterações?",
                CloseButtonText = "Não",
                PrimaryButtonText = "Sim"
            };

            ContentDialogResult resultado = await excluirDialog.ShowAsync();

            if (resultado == ContentDialogResult.Primary)
            {
                Repositorio.Edit(ListaCompras);
            }

            NavigationService.Navigate(typeof(ListaComprasPage));
        }

        public async void Excluir()
        {
            ContentDialog excluirDialog = new ContentDialog
            {
                Title = "Deseja apagar a lista?",
                Content = "A lista será apagada e não poderá ser recuperada",
                CloseButtonText = "Não",
                PrimaryButtonText = "Sim"
            };

            ContentDialogResult resultado = await excluirDialog.ShowAsync();

            if (resultado == ContentDialogResult.Primary)
            {
                Repositorio.Delete(ListaCompras);
            }

            NavigationService.Navigate(typeof(ListaComprasPage));
        }

        public void SalvarItem(Item item)
        {
            ItemRepository itemRepositorio = new ItemRepository();

            itemRepositorio.Edit(item);
        }

    }
}
