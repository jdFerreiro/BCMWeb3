namespace BCMWeb.Core.Entities
{
    public partial class BCPRestartVIPPerson
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long PersonId { get; set; }
        public string Activity { get; set; }
        public string Name { get; set; }
        public string IdentificationDocument { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public long? ChiefKeyPersonId { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
        public virtual Person PersonInfo { get; set; }
    }
}
