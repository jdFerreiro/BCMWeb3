using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblModulo
    {
        public TblModulo()
        {
            TblDocumentoContenido = new HashSet<TblDocumentoContenido>();
            TblModuloNivelUsuario = new HashSet<TblModuloNivelUsuario>();
            TblModuloUsuario = new HashSet<TblModuloUsuario>();
            TblPmtmensajeActualizacion = new HashSet<TblPmtmensajeActualizacion>();
            TblPmtprogramacion = new HashSet<TblPmtprogramacion>();
            TblPmtprogramacionDocumentos = new HashSet<TblPmtprogramacionDocumentos>();
            TblPmtresponsableUpdate = new HashSet<TblPmtresponsableUpdate>();
        }

        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public int? IdCodigoModulo { get; set; }
        public long IdModuloPadre { get; set; }
        public short IdTipoElemento { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Controller { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImageRoot { get; set; }
        public bool Activo { get; set; }
        public bool Negocios { get; set; }
        public bool Tecnologia { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblEmpresaModulo TblEmpresaModulo { get; set; }
        public virtual ICollection<TblDocumentoContenido> TblDocumentoContenido { get; set; }
        public virtual ICollection<TblModuloNivelUsuario> TblModuloNivelUsuario { get; set; }
        public virtual ICollection<TblModuloUsuario> TblModuloUsuario { get; set; }
        public virtual ICollection<TblPmtmensajeActualizacion> TblPmtmensajeActualizacion { get; set; }
        public virtual ICollection<TblPmtprogramacion> TblPmtprogramacion { get; set; }
        public virtual ICollection<TblPmtprogramacionDocumentos> TblPmtprogramacionDocumentos { get; set; }
        public virtual ICollection<TblPmtresponsableUpdate> TblPmtresponsableUpdate { get; set; }
    }
}
