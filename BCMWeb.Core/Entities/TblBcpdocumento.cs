using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBcpdocumento
    {
        public TblBcpdocumento()
        {
            TblBcpreanudacionPersonaClave = new HashSet<TblBcpreanudacionPersonaClave>();
            TblBcpreanudacionTarea = new HashSet<TblBcpreanudacionTarea>();
            TblBcprecuperacionPersonaClave = new HashSet<TblBcprecuperacionPersonaClave>();
            TblBcprecuperacionRecurso = new HashSet<TblBcprecuperacionRecurso>();
            TblBcprespuestaAccion = new HashSet<TblBcprespuestaAccion>();
            TblBcprespuestaRecurso = new HashSet<TblBcprespuestaRecurso>();
            TblBcprestauracionEquipo = new HashSet<TblBcprestauracionEquipo>();
            TblBcprestauracionInfraestructura = new HashSet<TblBcprestauracionInfraestructura>();
            TblBcprestauracionMobiliario = new HashSet<TblBcprestauracionMobiliario>();
            TblBcprestauracionOtro = new HashSet<TblBcprestauracionOtro>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long? IdDocumento { get; set; }
        public long? IdTipoDocumento { get; set; }
        public long? IdDocumentoBia { get; set; }
        public long? IdProceso { get; set; }
        public long? IdUnidadOrganizativa { get; set; }
        public string Proceso { get; set; }
        public string SubProceso { get; set; }
        public string Responsable { get; set; }

        public virtual TblDocumento Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblBiaproceso IdNavigation { get; set; }
        public virtual ICollection<TblBcpreanudacionPersonaClave> TblBcpreanudacionPersonaClave { get; set; }
        public virtual ICollection<TblBcpreanudacionTarea> TblBcpreanudacionTarea { get; set; }
        public virtual ICollection<TblBcprecuperacionPersonaClave> TblBcprecuperacionPersonaClave { get; set; }
        public virtual ICollection<TblBcprecuperacionRecurso> TblBcprecuperacionRecurso { get; set; }
        public virtual ICollection<TblBcprespuestaAccion> TblBcprespuestaAccion { get; set; }
        public virtual ICollection<TblBcprespuestaRecurso> TblBcprespuestaRecurso { get; set; }
        public virtual ICollection<TblBcprestauracionEquipo> TblBcprestauracionEquipo { get; set; }
        public virtual ICollection<TblBcprestauracionInfraestructura> TblBcprestauracionInfraestructura { get; set; }
        public virtual ICollection<TblBcprestauracionMobiliario> TblBcprestauracionMobiliario { get; set; }
        public virtual ICollection<TblBcprestauracionOtro> TblBcprestauracionOtro { get; set; }
    }
}
