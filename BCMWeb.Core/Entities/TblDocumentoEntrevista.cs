using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumentoEntrevista
    {
        public TblDocumentoEntrevista()
        {
            TblDocumentoEntrevistaPersona = new HashSet<TblDocumentoEntrevistaPersona>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdEntrevista { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public virtual TblDocumento Id { get; set; }
        public virtual ICollection<TblDocumentoEntrevistaPersona> TblDocumentoEntrevistaPersona { get; set; }
    }
}
