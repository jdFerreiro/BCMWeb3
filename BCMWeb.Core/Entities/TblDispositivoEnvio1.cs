using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivoEnvio1
    {
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public long IdEmpresa { get; set; }
        public long IdSubModulo { get; set; }
        public long IdUsuarioEnvia { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime? FechaDescarga { get; set; }
        public bool? Descargado { get; set; }

        public virtual TblEmpresaModulo Id { get; set; }
        public virtual TblDispositivo1 IdDispositivoNavigation { get; set; }
        public virtual User IdUsuarioEnviaNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
