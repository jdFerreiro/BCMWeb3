using System;

namespace BCMWeb.Core.Entities
{
    public class BIAProceso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int NroProceso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public bool Critico { get; set; }
        public long IdEstadoProceso { get; set; }
        public DateTime FechaUltimoEstatus { get; set; }
    }
}
