using ListaComprasApp.Entities;
using ListaComprasApp.Pages;
using ListaComprasApp.Repositories;
using ListaComprasApp.Services;
using ListaComprasApp.Utils;
using System;

namespace ListaComprasApp.ViewModels
{
    public class AddListaComprasViewModel : NotifyableClass
    {
        ListaComprasRepository Repositorio;

        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value;
                OnPropertyChanged();
            }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }

        private string _observacao;
        public string Observacao
        {
            get { return _observacao; }
            set
            {
                _observacao = value;
                OnPropertyChanged();
            }
        }

        public AddListaComprasViewModel()
        {
            Repositorio = new ListaComprasRepository();
            Data = DateTime.Now;
        }

        public void Salvar()
        {
            ListaCompras lista = new ListaCompras
            {
                Titulo = Titulo,
                Data = Data,
                Observacao = Observacao,
                Finalizado = false
            };

            Repositorio.Create(lista);

            NavigationService.Navigate(typeof(ListaComprasPage));
        }
    }
}
