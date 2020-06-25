using System;

namespace BCMWeb.Core.Entities
{
    public class BCPRestauracionInfraestructura
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdBCPRestauracionInfraestructura { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
