namespace BCMWeb.Core.Entities
{
    public class PersonPhone : BaseEntity
    {
        public long CompanyId { get; set; }
        public long PersonId { get; set; }
        public long PersonPhoneId { get; set; }
        public long PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual PhoneType PhoneTypeInfo { get; set; }
    }
}
