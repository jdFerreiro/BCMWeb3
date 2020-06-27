using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaPlanificacionParticipante
    {
        public TblPbepruebaPlanificacionParticipante()
        {
            TblPbepruebaPlanificacionEjercicioParticipante = new HashSet<TblPbepruebaPlanificacionEjercicioParticipante>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdParticipante { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public bool Responsable { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public virtual TblPbepruebaPlanificacion Id { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacionEjercicioParticipante> TblPbepruebaPlanificacionEjercicioParticipante { get; set; }
    }
}
