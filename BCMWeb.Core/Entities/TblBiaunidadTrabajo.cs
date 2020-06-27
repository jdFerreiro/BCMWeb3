using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiaunidadTrabajo
    {
        public TblBiaunidadTrabajo()
        {
            TblBiaunidadTrabajoProceso = new HashSet<TblBiaunidadTrabajoProceso>();
        }

        public long IdEmpresa { get; set; }
        public long IdUnidadTrabajo { get; set; }
        public string Nombre { get; set; }
        public long IdUnidadOrganizativa { get; set; }

        public virtual TblUnidadOrganizativa Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblBiaunidadTrabajoProceso> TblBiaunidadTrabajoProceso { get; set; }
    }
}
