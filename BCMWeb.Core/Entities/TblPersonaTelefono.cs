namespace BCMWeb.Core.Entities
{
    public partial class TblPersonaTelefono
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaTelefono { get; set; }
        public long IdTipoTelefono { get; set; }
        public string Telefono { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblTipoTelefono IdTipoTelefonoNavigation { get; set; }
    }
}
