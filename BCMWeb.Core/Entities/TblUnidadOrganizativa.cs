using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblUnidadOrganizativa
    {
        public TblUnidadOrganizativa()
        {
            TblBiadocumento = new HashSet<TblBiadocumento>();
            TblBiaproceso = new HashSet<TblBiaproceso>();
            TblBiaunidadTrabajo = new HashSet<TblBiaunidadTrabajo>();
            TblPersona = new HashSet<TblPersona>();
            TblUsuarioUnidadOrganizativa = new HashSet<TblUsuarioUnidadOrganizativa>();
        }

        public long IdEmpresa { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public string Nombre { get; set; }
        public long IdUnidadPadre { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblBiadocumento> TblBiadocumento { get; set; }
        public virtual ICollection<TblBiaproceso> TblBiaproceso { get; set; }
        public virtual ICollection<TblBiaunidadTrabajo> TblBiaunidadTrabajo { get; set; }
        public virtual ICollection<TblPersona> TblPersona { get; set; }
        public virtual ICollection<TblUsuarioUnidadOrganizativa> TblUsuarioUnidadOrganizativa { get; set; }
    }
}
