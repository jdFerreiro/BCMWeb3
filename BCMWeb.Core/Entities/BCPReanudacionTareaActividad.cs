using System;

namespace BCMWeb.Core.Entities
{
    public class BCPReanudacionTareaActividad
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdBCPReanudacionTarea { get; set; }
        public long IdBCPReanudacionTareaActividad { get; set; }
        public string Descripcion { get; set; }
        public bool Procesado { get; set; }
    }
}
