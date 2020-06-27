using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtprogramacion
    {
        public TblPmtprogramacion()
        {
            TblPmtprogramacionDocumentos = new HashSet<TblPmtprogramacionDocumentos>();
            TblPmtprogramacionUsuario = new HashSet<TblPmtprogramacionUsuario>();
        }

        public long IdPmtprogramacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public long IdEstado { get; set; }
        public bool Negocios { get; set; }
        public short IdTipoActualizacion { get; set; }
        public long IdTipoFrecuencia { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblPmtprogramacionTipoActualizacion IdTipoActualizacionNavigation { get; set; }
        public virtual TblTipoFrecuencia IdTipoFrecuenciaNavigation { get; set; }
        public virtual ICollection<TblPmtprogramacionDocumentos> TblPmtprogramacionDocumentos { get; set; }
        public virtual ICollection<TblPmtprogramacionUsuario> TblPmtprogramacionUsuario { get; set; }
    }
}
