using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblNivelUsuario
    {
        public TblNivelUsuario()
        {
            TblCulturaNivelUsuario = new HashSet<TblCulturaNivelUsuario>();
            TblEmpresaUsuario = new HashSet<TblEmpresaUsuario>();
            TblModuloNivelUsuario = new HashSet<TblModuloNivelUsuario>();
            TblUsuarioUnidadOrganizativa = new HashSet<TblUsuarioUnidadOrganizativa>();
        }

        public long IdNivelUsuario { get; set; }
        public bool TodosDocs { get; set; }
        public string RolUsuario { get; set; }

        public virtual ICollection<TblCulturaNivelUsuario> TblCulturaNivelUsuario { get; set; }
        public virtual ICollection<TblEmpresaUsuario> TblEmpresaUsuario { get; set; }
        public virtual ICollection<TblModuloNivelUsuario> TblModuloNivelUsuario { get; set; }
        public virtual ICollection<TblUsuarioUnidadOrganizativa> TblUsuarioUnidadOrganizativa { get; set; }
    }
}
