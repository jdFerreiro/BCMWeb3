using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivoConexion
    {
        public long IdEmpresa { get; set; }
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaConexion { get; set; }
        public string DireccionIp { get; set; }

        public virtual TblDispositivo IdDispositivoNavigation { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
