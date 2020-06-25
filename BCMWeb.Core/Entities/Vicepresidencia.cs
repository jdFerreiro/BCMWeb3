using System;

namespace BCMWeb.Core.Entities
{
    public class Vicepresidencia
    {
        public long IdEmpresa { get; set; }
        public long IdVicepresidencia { get; set; }
        public string Nombre { get; set; }
        public string CalleAvenida { get; set; }
        public string EdificioCasa { get; set; }
        public string PisoNivel { get; set; }
        public string TorreAla { get; set; }
        public string Urbanizacion { get; set; }
        public long IdCiudad { get; set; }
        public long IdEstado { get; set; }
        public long IdPais { get; set; }
    }
}
