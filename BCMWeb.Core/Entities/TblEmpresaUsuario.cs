using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblEmpresaUsuario
    {
        public long IdEmpresa { get; set; }
        public long IdUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public long IdNivelUsuario { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblNivelUsuario IdNivelUsuarioNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
