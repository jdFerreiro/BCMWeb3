using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstadoUsuario
    {
        public TblEstadoUsuario()
        {
            TblCulturaEstadoUsuario = new HashSet<TblCulturaEstadoUsuario>();
            TblUsuario = new HashSet<User>();
        }

        public short IdEstadoUsuario { get; set; }

        public virtual ICollection<TblCulturaEstadoUsuario> TblCulturaEstadoUsuario { get; set; }
        public virtual ICollection<User> TblUsuario { get; set; }
    }
}
