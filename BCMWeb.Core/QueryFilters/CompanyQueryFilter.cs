namespace BCMWeb.Core.QueryFilters
{
    public class CompanyQueryFilter : PaginationFilter
    {
        public long? UserId { get; set; }
        public long? CountryId { get; set; }
        public long? CountryStateId { get; set; }
        public long? CityId { get; set; }
    }
}
