namespace BCMWeb.Core.Entities
{
    public partial class TblBcpreanudacionTareaActividad
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdBcpreanudacionTarea { get; set; }
        public long IdBcpreanudacionTareaActividad { get; set; }
        public string Descripcion { get; set; }
        public bool Procesado { get; set; }

        public virtual TblBcpreanudacionTarea Id { get; set; }
    }
}
