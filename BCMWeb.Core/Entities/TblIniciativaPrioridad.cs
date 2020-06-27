using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblIniciativaPrioridad
    {
        public TblIniciativaPrioridad()
        {
            TblIniciativas = new HashSet<TblIniciativas>();
        }

        public long IdEmpresa { get; set; }
        public short IdPrioridad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblIniciativas> TblIniciativas { get; set; }
    }
}
