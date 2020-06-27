using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblAuditoria
    {
        public long IdAuditoria { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdDocumento { get; set; }
        public long? IdTipoDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DireccionIp { get; set; }
        public string Mensaje { get; set; }
        public string Accion { get; set; }
        public long? IdUsuario { get; set; }
        public bool Negocios { get; set; }
        public string DatosModificados { get; set; }

        public virtual TblDocumento Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
