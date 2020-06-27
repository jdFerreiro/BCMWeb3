using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstadoRiesgo
    {
        public TblEstadoRiesgo()
        {
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
        }

        public long IdEmpresa { get; set; }
        public short IdEstadoRiesgo { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }

        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
    }
}
