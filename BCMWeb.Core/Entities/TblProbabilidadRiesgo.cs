using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblProbabilidadRiesgo
    {
        public TblProbabilidadRiesgo()
        {
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
        }

        public long IdEmpresa { get; set; }
        public short IdProbabilidad { get; set; }
        public string Nombre { get; set; }
        public string EtiquetaGrafico { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
    }
}
