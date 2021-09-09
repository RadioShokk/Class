using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class producto
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Nombre { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public int Existencia { get; set; }
        [JsonProperty]
        public decimal Precio { get; set; }
        [JsonProperty]
        public decimal FechaVencimiento { get; set; }
        [JsonProperty]
        public decimal UnidadMedida { get; set; }

        public class ProductoPrecioComparer : IComparer<producto>
        {
            public int
        }

    }
}
