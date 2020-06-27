using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBcpreanudacionTarea
    {
        public TblBcpreanudacionTarea()
        {
            TblBcpreanudacionTareaActividad = new HashSet<TblBcpreanudacionTareaActividad>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdBcpreanudacionTarea { get; set; }
        public string Nombre { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
        public virtual ICollection<TblBcpreanudacionTareaActividad> TblBcpreanudacionTareaActividad { get; set; }
    }
}
