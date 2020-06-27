using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiaamenazaEvento
    {
        public TblBiaamenazaEvento()
        {
            TblBiaeventoControl = new HashSet<TblBiaeventoControl>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdAmenazaEvento { get; set; }
        public string Nombre { get; set; }
        public long IdEventoRiesgo { get; set; }

        public virtual ICollection<TblBiaeventoControl> TblBiaeventoControl { get; set; }
    }
}
