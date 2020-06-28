namespace BCMWeb.Core.Entities
{
    public partial class BIAWorkUnitPerson
    {
        public long CompanyId { get; set; }
        public long WorkUnitId { get; set; }
        public long WorkUnitProcessId { get; set; }
        public long PersonUnitId { get; set; }
        public long ProcessClientId { get; set; }
        public string Name { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }

        public virtual BIAWorkUnitProcess BIAWorkUnitProcessInfo { get; set; }
        public virtual BIAProcessClient BIACLientProcessInfo { get; set; }
    }
}
