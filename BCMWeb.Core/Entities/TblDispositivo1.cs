using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblDispositivo1
    {
        public TblDispositivo1()
        {
            TblDispositivoConexion1 = new HashSet<TblDispositivoConexion1>();
            TblDispositivoEnvio1 = new HashSet<TblDispositivoEnvio1>();
        }

        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string ImeiDispositivo { get; set; }
        public string NombreDispositivo { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Plataforma { get; set; }
        public string Version { get; set; }
        public string TipoDispositivo { get; set; }
        public string TokenDispositivo { get; set; }

        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<TblDispositivoConexion1> TblDispositivoConexion1 { get; set; }
        public virtual ICollection<TblDispositivoEnvio1> TblDispositivoEnvio1 { get; set; }
    }
}
