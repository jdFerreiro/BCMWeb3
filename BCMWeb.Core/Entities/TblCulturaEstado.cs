namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaEstado
    {
        public string Culture { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public string Nombre { get; set; }

        public virtual TblEstado Id { get; set; }
    }
}
