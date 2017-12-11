﻿using ListaComprasApp.Entities;
using ListaComprasApp.Pages;
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
            ListaCompras = new List<ListaCompras>() {
                new ListaCompras()
                {
                    Data = DateTime.Now,
                    Finalizado = false,
                    Titulo = "Teste de observação",
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Nome = "Nescau",
                            Quantidade = 1,
                            Concluido = false,
                            Observacao = "Só o Felipe toma com leite"
                        },

                        new Item()
                        {
                            Nome = "Toddy",
                            Quantidade = 1,
                            Concluido = false,
                            Observacao = "Só a Thais toma com leite"
                        },

                        new Item()
                        {
                            Nome = "Salgadinho",
                            Quantidade = 2,
                            Concluido = false,
                            Observacao = "Thais come Ruffles e o Felipe come Doritos"
                        }
                    }
                },
                new ListaCompras()
                {
                    Data = DateTime.Now,
                    Finalizado = true,
                    Titulo = "Teste de observação 2",
                    Items = new List<Item>()
                }
            };
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
