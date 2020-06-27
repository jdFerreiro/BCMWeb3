using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiadocumento
    {
        public TblBiadocumento()
        {
            TblBiacomentario = new HashSet<TblBiacomentario>();
            TblBiaproceso = new HashSet<TblBiaproceso>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long? IdDocumento { get; set; }
        public long? IdUnidadOrganizativa { get; set; }
        public long? IdCadenaServicio { get; set; }
        public long? IdTipoDocumento { get; set; }

        public virtual TblUnidadOrganizativa Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblDocumento IdNavigation { get; set; }
        public virtual ICollection<TblBiacomentario> TblBiacomentario { get; set; }
        public virtual ICollection<TblBiaproceso> TblBiaproceso { get; set; }
    }
}
