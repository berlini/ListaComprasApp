﻿using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;

namespace ListaComprasAppService.DataObjects
{
    public class ListaCompras : EntityData
    {
        public string ListaId { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
        public bool Finalizado { get; set; }
        public List<Item> Items { get; set; }
    }
}