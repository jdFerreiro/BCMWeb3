using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Core.Entities
{
    public class Auditoria
    {
        public long IdAuditoria { get; set; }
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DireccionIP { get; set; }
        public string Mensaje { get; set; }
        public string Accion { get; set; }
        public long IdUsuario { get; set; }
        public bool Negocios { get; set; }
        public string DatosModificados { get; set; }

    }
}
