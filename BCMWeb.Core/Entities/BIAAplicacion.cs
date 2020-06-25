using System;

namespace BCMWeb.Core.Entities
{
    public class BIAAplicacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdAplicacion { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
    }
}
