namespace BCMWeb.Core.Entities
{
    public partial class TblPersonaDireccion
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaDireccion { get; set; }
        public long IdTipoDireccion { get; set; }
        public string Ubicacion { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblCiudad Id1 { get; set; }
        public virtual TblEstado IdNavigation { get; set; }
        public virtual TblPais IdPaisNavigation { get; set; }
        public virtual TblTipoDireccion IdTipoDireccionNavigation { get; set; }
    }
}
