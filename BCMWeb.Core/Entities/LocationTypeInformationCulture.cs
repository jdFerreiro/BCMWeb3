namespace BCMWeb.Core.Entities
{
    public partial class LocationTypeInformationCulture
    {
        public string Culture { get; set; }
        public int LocationTypeInformationId { get; set; }
        public string Description { get; set; }

        public virtual LocationTypeInformation LocationTypeInformationInfo { get; set; }
    }
}
