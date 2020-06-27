using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEjecucion
    {
        public TblPbepruebaEjecucion()
        {
            TblPbepruebaEjecucionEjercicio = new HashSet<TblPbepruebaEjecucionEjercicio>();
            TblPbepruebaEjecucionParticipante = new HashSet<TblPbepruebaEjecucionParticipante>();
            TblPbepruebaEjecucionResultado = new HashSet<TblPbepruebaEjecucionResultado>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Lugar { get; set; }

        public virtual TblPbepruebaPlanificacion Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicio> TblPbepruebaEjecucionEjercicio { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionParticipante> TblPbepruebaEjecucionParticipante { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionResultado> TblPbepruebaEjecucionResultado { get; set; }
    }
}
