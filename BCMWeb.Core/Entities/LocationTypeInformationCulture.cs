namespace BCMWeb.Core.Entities
{
    public class LocationTypeInformationCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int LocationTypeInformationId { get; set; }
        public string Description { get; set; }

        public virtual LocationTypeInformation LocationTypeInformationInfo { get; set; }
    }
}
