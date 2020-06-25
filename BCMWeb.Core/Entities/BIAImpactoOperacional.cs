using System;

namespace BCMWeb.Core.Entities
{
    public class BIAImpactoOperacional
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdImpactoOperacional { get; set; }
        public long IdTipoFrecuencia { get; set; }
        public string ImpactoOperacional { get; set; }
        public string Descripcion { get; set; }
        public long IdEscala { get; set; }
        public string UnidadTiempo { get; set; }
    }
}
