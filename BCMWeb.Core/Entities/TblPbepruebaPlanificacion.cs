using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaPlanificacion
    {
        public TblPbepruebaPlanificacion()
        {
            TblPbepruebaPlanificacionEjercicio = new HashSet<TblPbepruebaPlanificacionEjercicio>();
            TblPbepruebaPlanificacionEjercicioRecurso = new HashSet<TblPbepruebaPlanificacionEjercicioRecurso>();
            TblPbepruebaPlanificacionParticipante = new HashSet<TblPbepruebaPlanificacionParticipante>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public bool Negocios { get; set; }
        public string Prueba { get; set; }
        public string Propósito { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Lugar { get; set; }
        public short? IdEstatus { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblPbepruebaEjecucion TblPbepruebaEjecucion { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionEjercicio> TblPbepruebaPlanificacionEjercicio { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionEjercicioRecurso> TblPbepruebaPlanificacionEjercicioRecurso { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionParticipante> TblPbepruebaPlanificacionParticipante { get; set; }
    }
}
