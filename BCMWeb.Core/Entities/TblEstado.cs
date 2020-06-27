using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstado
    {
        public TblEstado()
        {
            TblCiudad = new HashSet<TblCiudad>();
            TblCulturaEstado = new HashSet<TblCulturaEstado>();
            TblEmpresa = new HashSet<TblEmpresa>();
            TblLocalidad = new HashSet<TblLocalidad>();
            TblPersonaDireccion = new HashSet<TblPersonaDireccion>();
        }

        public long IdPais { get; set; }
        public long IdEstado { get; set; }

        public virtual TblPais IdPaisNavigation { get; set; }
        public virtual ICollection<TblCiudad> TblCiudad { get; set; }
        public virtual ICollection<TblCulturaEstado> TblCulturaEstado { get; set; }
        public virtual ICollection<TblEmpresa> TblEmpresa { get; set; }
        public virtual ICollection<TblLocalidad> TblLocalidad { get; set; }
        public virtual ICollection<TblPersonaDireccion> TblPersonaDireccion { get; set; }
    }
}
