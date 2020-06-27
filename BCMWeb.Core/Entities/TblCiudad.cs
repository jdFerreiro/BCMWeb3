using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblCiudad
    {
        public TblCiudad()
        {
            TblCulturaCiudad = new HashSet<TblCulturaCiudad>();
            TblEmpresa = new HashSet<TblEmpresa>();
            TblLocalidad = new HashSet<TblLocalidad>();
            TblPersonaDireccion = new HashSet<TblPersonaDireccion>();
        }

        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }

        public virtual TblEstado Id { get; set; }
        public virtual TblPais IdPaisNavigation { get; set; }
        public virtual ICollection<TblCulturaCiudad> TblCulturaCiudad { get; set; }
        public virtual ICollection<TblEmpresa> TblEmpresa { get; set; }
        public virtual ICollection<TblLocalidad> TblLocalidad { get; set; }
        public virtual ICollection<TblPersonaDireccion> TblPersonaDireccion { get; set; }
    }
}
