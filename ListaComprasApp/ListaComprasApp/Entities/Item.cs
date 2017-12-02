using ListaComprasApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComprasApp.Entities
{
    public class Item : NotifyableClass
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
                OnPropertyChanged();
            }
        }

        private bool _concluido;
        public bool Concluido
        {
            get { return _concluido; }
            set
            {
                _concluido = value;
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

    }
}
