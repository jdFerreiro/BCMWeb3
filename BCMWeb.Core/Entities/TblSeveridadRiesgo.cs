using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblSeveridadRiesgo
    {
        public TblSeveridadRiesgo()
        {
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
        }

        public long IdEmpresa { get; set; }
        public short IdSeveridad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
    }
}
