using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;

namespace ListaComprasAppService.DataObjects
{
    public class Item : EntityData
    {
        [JsonProperty("id")]
        public string ItemId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public bool Concluido { get; set; }
        public string Observacao { get; set; }
    }
}