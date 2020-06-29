namespace BCMWeb.Core.Entities
{
    public class BCPRecoveryKeyPerson : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long PersonId { get; set; }
        public string Activity { get; set; }
        public string Name { get; set; }
        public string GovermentDocumentId { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Email { get; set; }
        public string RoomAddress { get; set; }
        public long? ChiefKeyPersonalId { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
        public virtual Person PersonInfo { get; set; }
    }
}
