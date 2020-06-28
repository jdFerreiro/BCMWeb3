namespace BCMWeb.Core.Entities
{
    public partial class PersonEmail
    {
        public long CompanyId { get; set; }
        public long PersonId { get; set; }
        public long PersonEmailId { get; set; }
        public string Email { get; set; }
        public long EmailTypeId { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual EmailType EmailTypeInfo { get; set; }
    }
}
