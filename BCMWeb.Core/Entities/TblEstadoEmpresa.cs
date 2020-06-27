using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstadoEmpresa
    {
        public TblEstadoEmpresa()
        {
            TblCulturaEstadoEmpresa = new HashSet<TblCulturaEstadoEmpresa>();
            TblEmpresa = new HashSet<TblEmpresa>();
        }

        public long IdEstadoEmpresa { get; set; }

        public virtual ICollection<TblCulturaEstadoEmpresa> TblCulturaEstadoEmpresa { get; set; }
        public virtual ICollection<TblEmpresa> TblEmpresa { get; set; }
    }
}
