namespace BCMWeb.Core.Entities
{
    public partial class CountryStateCulture
    {
        public string Culture { get; set; }
        public long CountryId { get; set; }
        public long CountryStateId { get; set; }
        public string Name { get; set; }

        public virtual CountryState CountryStateInfo { get; set; }
    }
}
