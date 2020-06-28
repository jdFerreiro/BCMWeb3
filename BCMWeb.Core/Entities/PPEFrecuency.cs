namespace BCMWeb.Core.Entities
{
    public partial class PPEFrecuency
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long PPEFrecuencyId { get; set; }
        public string TestType { get; set; }
        public string Participants { get; set; }
        public string Purpose { get; set; }
        public long FrecuencyTypeId { get; set; }

        public virtual Document DocumentInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
