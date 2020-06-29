namespace BCMWeb.Core.Entities
{
    public class IncidentTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int IncidentTypeId { get; set; }
        public string Descripcion { get; set; }

        public virtual IncidentType IncidentTypeInfo { get; set; }
    }
}
