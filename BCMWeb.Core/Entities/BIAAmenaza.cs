using System;

namespace BCMWeb.Core.Entities
{
    public class BIAAmenaza
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public string Evento { get; set; }
        public string TipoControlImplantado { get; set; }
        public string ControlesImplantar { get; set; }
        public Int16 Probabilidad { get; set; }
        public Int16 Impacto { get; set; }
        public Int16 Control { get; set; }
        public Int16 Severidad { get; set; }
        public string Fuente { get; set; }
        public Int16 Estado { get; set; }
    }
}
