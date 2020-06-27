using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivoConexion1
    {
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaConexion { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSubModulo { get; set; }
        public string DirecciónIp { get; set; }

        public virtual TblDispositivo1 IdDispositivoNavigation { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
