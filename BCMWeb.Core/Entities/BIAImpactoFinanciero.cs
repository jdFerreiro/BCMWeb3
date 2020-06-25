using System;

namespace BCMWeb.Core.Entities
{
    public class BIAImpactoFinanciero
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdImpactoFinanciero { get; set; }
        public long IdTipoFrecuencia { get; set; }
        public string Descripcion { get; set; }
        public string Impacto { get; set; }
        public long IdEscala { get; set; }
        public string UnidadTiempo { get; set; }
    }
}
