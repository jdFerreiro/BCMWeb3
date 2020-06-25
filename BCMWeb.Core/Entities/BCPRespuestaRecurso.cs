using System;

namespace BCMWeb.Core.Entities
{
    public class BCPRespuestaRecurso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdRespuestaRecurso { get; set; }
        public Int16 Cantidad { get; set; }
        public string Nombre { get; set; }
    }
}
