namespace BCMWeb.Core.Entities
{
    public class BIAUnidadTrabajoProceso
    {
        public long IdEmpresa { get; set; }
        public long IdUnidadTrabajo { get; set; }
        public long IdUnidadTrabajoProceso { get; set; }
        public string Nombre { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
    }
}
