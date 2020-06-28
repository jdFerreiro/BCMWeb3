namespace BCMWeb.Core.Entities
{
    public partial class DocumentInterviewPerson
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long InterviewId { get; set; }
        public long InterviewPersonId { get; set; }
        public bool IsInterviewer { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }

        public virtual DocumentInterview DocumentInterviewInfo { get; set; }
    }
}
