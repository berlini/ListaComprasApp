using ListaComprasApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListaComprasApp.Entities
{
    public class ListaCompras : NotifyableClass
    {
        private string _lidtaId;
        [Key]
        public string ListaId
        {
            get { return _lidtaId; }
            set
            {
                _lidtaId = value;
                OnPropertyChanged();
            }
        }

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

        private bool _finalizado;
        public bool Finalizado
        {
            get { return _finalizado; }
            set
            {
                _finalizado = value;
                OnPropertyChanged();
            }
        }

        private List<Item> _items;
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public ListaCompras()
        {
            Items = new List<Item>();
        }
    }
}
