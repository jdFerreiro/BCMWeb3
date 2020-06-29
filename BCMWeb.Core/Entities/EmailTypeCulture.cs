namespace BCMWeb.Core.Entities
{
    public class EmailTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long EmailTypeId { get; set; }
        public string Description { get; set; }

        public virtual EmailType EmailTypeInfo { get; set; }
    }
}
