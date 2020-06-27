using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaPlanificacionEjercicio
    {
        public TblPbepruebaPlanificacionEjercicio()
        {
            TblPbepruebaPlanificacionEjercicioParticipante = new HashSet<TblPbepruebaPlanificacionEjercicioParticipante>();
            TblPbepruebaPlanificacionEjercicioRecurso = new HashSet<TblPbepruebaPlanificacionEjercicioRecurso>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionHoras { get; set; }
        public int DuracionMinutos { get; set; }

        public virtual TblPbepruebaPlanificacion Id { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionEjercicioParticipante> TblPbepruebaPlanificacionEjercicioParticipante { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionEjercicioRecurso> TblPbepruebaPlanificacionEjercicioRecurso { get; set; }
    }
}
