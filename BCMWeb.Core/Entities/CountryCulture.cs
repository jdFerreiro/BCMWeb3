namespace BCMWeb.Core.Entities
{
    public partial class CountryCulture
    {
        public string Culture { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country CountryInfo { get; set; }
    }
}
