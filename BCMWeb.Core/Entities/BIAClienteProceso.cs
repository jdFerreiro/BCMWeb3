using System;

namespace BCMWeb.Core.Entities
{
    public class BIAClienteProceso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdClienteProceso { get; set; }
        public string Unidad { get; set; }
        public string Responsable { get; set; }
        public string Proceso { get; set; }
        public string Producto { get; set; }
    }
}
