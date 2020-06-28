namespace BCMWeb.Core.Entities
{
    public partial class VicePresidency
    {
        public long CompanyId { get; set; }
        public long VicepresidencyId { get; set; }
        public string Name { get; set; }
        public string AvenueStreetName { get; set; }
        public string BuildingHouseName { get; set; }
        public string FloorLevel { get; set; }
        public string TowerSideName { get; set; }
        public string UrbanizationName { get; set; }
        public long CityId { get; set; }
        public long StateId { get; set; }
        public long CountryId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual Country CountryInfo { get; set; }
    }
}
