using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblCriticidad
    {
        public DateTime FechaAplicacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdTipoEscala { get; set; }
        public string DescripcionEscala { get; set; }

        public virtual TblEscala Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
