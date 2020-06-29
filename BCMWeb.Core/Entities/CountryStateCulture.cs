namespace BCMWeb.Core.Entities
{
    public class CountryStateCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long CountryId { get; set; }
        public long CountryStateId { get; set; }
        public string Name { get; set; }

        public virtual CountryState CountryStateInfo { get; set; }
    }
}
