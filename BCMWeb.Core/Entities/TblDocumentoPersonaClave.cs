using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumentoPersonaClave
    {
        public TblDocumentoPersonaClave()
        {
            TblBiapersonaClave = new HashSet<TblBiapersonaClave>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoHabitacion { get; set; }
        public string Correo { get; set; }
        public string DireccionHabitacion { get; set; }
        public bool? Principal { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblDocumento IdNavigation { get; set; }
        public virtual ICollection<TblBiapersonaClave> TblBiapersonaClave { get; set; }
    }
}
