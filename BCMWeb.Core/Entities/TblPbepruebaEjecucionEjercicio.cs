using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEjecucionEjercicio
    {
        public TblPbepruebaEjecucionEjercicio()
        {
            TblPbepruebaEjecucionEjercicioParticipante = new HashSet<TblPbepruebaEjecucionEjercicioParticipante>();
            TblPbepruebaEjecucionEjercicioRecurso = new HashSet<TblPbepruebaEjecucionEjercicioRecurso>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionHoras { get; set; }
        public int DuracionMinutos { get; set; }
        public short? IdEstatus { get; set; }
        public long IdEjercicioPlanificacion { get; set; }

        public virtual TblPbepruebaEjecucion Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblPbepruebaEstatus IdEstatusNavigation { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicioParticipante> TblPbepruebaEjecucionEjercicioParticipante { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicioRecurso> TblPbepruebaEjecucionEjercicioRecurso { get; set; }
    }
}
