using System;

namespace BCMWeb.Core.Entities
{
    public class Cultura_Ciudad
    {
        public string Culture { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }
        public string Nombre { get; set; }
    }
}
