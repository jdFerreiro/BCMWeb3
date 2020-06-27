using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPersona
    {
        public TblPersona()
        {
            TblBcpreanudacionPersonaClave = new HashSet<TblBcpreanudacionPersonaClave>();
            TblBcprecuperacionPersonaClave = new HashSet<TblBcprecuperacionPersonaClave>();
            TblBiapersonaRespaldoProceso = new HashSet<TblBiapersonaRespaldoProceso>();
            TblDocumentoAprobacion = new HashSet<TblDocumentoAprobacion>();
            TblDocumentoCertificacion = new HashSet<TblDocumentoCertificacion>();
            TblDocumentoPersonaClave = new HashSet<TblDocumentoPersonaClave>();
            TblPersonaCorreo = new HashSet<TblPersonaCorreo>();
            TblPersonaDireccion = new HashSet<TblPersonaDireccion>();
            TblPersonaTelefono = new HashSet<TblPersonaTelefono>();
        }

        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public long? IdUnidadOrganizativa { get; set; }
        public long? IdCargo { get; set; }
        public long? IdUsuario { get; set; }

        public virtual TblCargo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblUnidadOrganizativa IdNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<TblBcpreanudacionPersonaClave> TblBcpreanudacionPersonaClave { get; set; }
        public virtual ICollection<TblBcprecuperacionPersonaClave> TblBcprecuperacionPersonaClave { get; set; }
        public virtual ICollection<TblBiapersonaRespaldoProceso> TblBiapersonaRespaldoProceso { get; set; }
        public virtual ICollection<TblDocumentoAprobacion> TblDocumentoAprobacion { get; set; }
        public virtual ICollection<TblDocumentoCertificacion> TblDocumentoCertificacion { get; set; }
        public virtual ICollection<TblDocumentoPersonaClave> TblDocumentoPersonaClave { get; set; }
        public virtual ICollection<TblPersonaCorreo> TblPersonaCorreo { get; set; }
        public virtual ICollection<TblPersonaDireccion> TblPersonaDireccion { get; set; }
        public virtual ICollection<TblPersonaTelefono> TblPersonaTelefono { get; set; }
    }
}
