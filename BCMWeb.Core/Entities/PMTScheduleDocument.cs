namespace BCMWeb.Core.Entities
{
    public partial class PMTScheduleDocument
    {
        public long PMTScheduleId { get; set; }
        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
        public virtual PMTSchedule PMTScheduleInfo { get; set; }
    }
}
