using System;

namespace BCMWeb.Core.Entities
{
    public class Escala
    {
        public long IdEmpresa { get; set; }
        public long IdEscala { get; set; }
        public long IdTipoEscala { get; set; }
        public Int16 Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int PosicionEscala { get; set; }
    }
}
