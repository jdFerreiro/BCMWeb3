using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEmpresaModulo
    {
        public TblEmpresaModulo()
        {
            TblDispositivoEnvio1 = new HashSet<TblDispositivoEnvio1>();
        }

        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblDispositivoEnvio1> TblDispositivoEnvio1 { get; set; }
    }
}
