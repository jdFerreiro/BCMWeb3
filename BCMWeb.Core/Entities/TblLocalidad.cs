namespace BCMWeb.Core.Entities
{
    public partial class TblLocalidad
    {
        public long IdEmpresa { get; set; }
        public long IdLocalidad { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }

        public virtual TblEstado Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblCiudad IdNavigation { get; set; }
        public virtual TblPais IdPaisNavigation { get; set; }
    }
}
