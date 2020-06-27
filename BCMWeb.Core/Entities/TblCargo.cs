using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblCargo
    {
        public TblCargo()
        {
            TblPersona = new HashSet<TblPersona>();
        }

        public long IdEmpresa { get; set; }
        public long IdCargo { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblPersona> TblPersona { get; set; }
    }
}
