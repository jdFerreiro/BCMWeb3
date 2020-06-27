namespace BCMWeb.Core.Entities
{
    public partial class TblBcprecuperacionPersonaClave
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdPersona { get; set; }
        public string Actividad { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoHabitacion { get; set; }
        public string Correo { get; set; }
        public string DireccionHabitacion { get; set; }
        public long? IdPersonaClavePrincipal { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
        public virtual TblPersona IdNavigation { get; set; }
    }
}
