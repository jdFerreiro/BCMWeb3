namespace BCMWeb.Core.Entities
{
    public class BCPAnswerAction : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPAnswerActionId { get; set; }
        public long PersonId { get; set; }
        public short ScaleLevel { get; set; }
        public string ScaleName { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
