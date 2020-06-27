using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEjecucionParticipante
    {
        public TblPbepruebaEjecucionParticipante()
        {
            TblPbepruebaEjecucionEjercicioParticipante = new HashSet<TblPbepruebaEjecucionEjercicioParticipante>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdParticipante { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public bool Responsable { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public long IdPlanificacionParticipante { get; set; }

        public virtual TblPbepruebaEjecucion Id { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicioParticipante> TblPbepruebaEjecucionEjercicioParticipante { get; set; }
    }
}
