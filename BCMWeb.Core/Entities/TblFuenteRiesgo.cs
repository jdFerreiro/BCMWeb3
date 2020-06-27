using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblFuenteRiesgo
    {
        public TblFuenteRiesgo()
        {
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
        }

        public long IdEmpresa { get; set; }
        public string CodigoFuente { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
    }
}
