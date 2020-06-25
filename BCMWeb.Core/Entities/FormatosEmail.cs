namespace BCMWeb.Core.Entities
{
    public class FormatosEmail
    {
        public long IdEmpresa { get; set; }
        public long IdCodigoModulo { get; set; }
        public int IdCorreo { get; set; }
        public string Descripcion { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }
    }
}
