using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblImpactoRiesgo
    {
        public TblImpactoRiesgo()
        {
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
        }

        public long IdEmpresa { get; set; }
        public short IdImpacto { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
    }
}
