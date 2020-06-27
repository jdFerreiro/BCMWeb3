using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblIniciativasAnexo
    {
        public long IdEmpresa { get; set; }
        public long IdIniciativa { get; set; }
        public long IdAnexo { get; set; }
        public string Nombre { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
