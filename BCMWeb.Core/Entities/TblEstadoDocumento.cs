using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstadoDocumento
    {
        public TblEstadoDocumento()
        {
            TblCulturaEstadoDocumento = new HashSet<TblCulturaEstadoDocumento>();
            TblDocumento = new HashSet<TblDocumento>();
        }

        public long IdEstadoDocumento { get; set; }

        public virtual ICollection<TblCulturaEstadoDocumento> TblCulturaEstadoDocumento { get; set; }
        public virtual ICollection<TblDocumento> TblDocumento { get; set; }
    }
}
