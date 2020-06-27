using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivoEnvio
    {
        public long IdDispositivo { get; set; }
        public long IdSubModulo { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdUsuarioEnvia { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaDescarga { get; set; }
        public bool? Descargado { get; set; }

        public virtual TblDispositivo IdDispositivoNavigation { get; set; }
    }
}
