using System;

namespace BCMWeb.Core.Entities
{
    public class Iniciativas_Anexo
    {
        public long IdEmpresa { get; set; }
        public long IdIniciativa { get; set; }
        public long IdAnexo { get; set; }
        public string Nombre { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
