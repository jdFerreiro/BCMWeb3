namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEjecucionResultado
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdContenido { get; set; }
        public byte[] Contenido { get; set; }

        public virtual TblPbepruebaEjecucion Id { get; set; }
    }
}
