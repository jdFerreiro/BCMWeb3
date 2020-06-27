using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPais
    {
        public TblPais()
        {
            TblCiudad = new HashSet<TblCiudad>();
            TblCulturaPais = new HashSet<TblCulturaPais>();
            TblEmpresa = new HashSet<TblEmpresa>();
            TblEstado = new HashSet<TblEstado>();
            TblLocalidad = new HashSet<TblLocalidad>();
            TblPersonaDireccion = new HashSet<TblPersonaDireccion>();
            TblVicepresidencia = new HashSet<TblVicepresidencia>();
        }

        public long IdPais { get; set; }

        public virtual ICollection<TblCiudad> TblCiudad { get; set; }
        public virtual ICollection<TblCulturaPais> TblCulturaPais { get; set; }
        public virtual ICollection<TblEmpresa> TblEmpresa { get; set; }
        public virtual ICollection<TblEstado> TblEstado { get; set; }
        public virtual ICollection<TblLocalidad> TblLocalidad { get; set; }
        public virtual ICollection<TblPersonaDireccion> TblPersonaDireccion { get; set; }
        public virtual ICollection<TblVicepresidencia> TblVicepresidencia { get; set; }
    }
}
