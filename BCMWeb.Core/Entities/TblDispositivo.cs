using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivo
    {
        public TblDispositivo()
        {
            TblDispositivoConexion = new HashSet<TblDispositivoConexion>();
            TblDispositivoEnvio = new HashSet<TblDispositivoEnvio>();
        }

        public long IdDispositivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string IdUnicoDispositivo { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Plataforma { get; set; }
        public string Version { get; set; }
        public string Tipo { get; set; }
        public string Token { get; set; }

        public virtual ICollection<TblDispositivoConexion> TblDispositivoConexion { get; set; }
        public virtual ICollection<TblDispositivoEnvio> TblDispositivoEnvio { get; set; }
    }
}
