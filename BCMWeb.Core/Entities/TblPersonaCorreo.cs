namespace BCMWeb.Core.Entities
{
    public partial class TblPersonaCorreo
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaCorreo { get; set; }
        public string Correo { get; set; }
        public long IdTipoCorreo { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblTipoCorreo IdTipoCorreoNavigation { get; set; }
    }
}
