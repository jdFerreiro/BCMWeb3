using System;

namespace BCMWeb.Core.Entities
{
    public class BIAComentario
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdComentario { get; set; }
        public string Descripcion { get; set; }
    }
}
