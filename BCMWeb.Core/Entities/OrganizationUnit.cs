using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class OrganizationUnit : BaseEntity
    {
        public OrganizationUnit()
        {
            BIADocuments = new HashSet<BIADocument>();
            BIAProcesses = new HashSet<BIAProcess>();
            BIAWorkUnits = new HashSet<BIAWorkUnit>();
            Persons = new HashSet<Person>();
            UserOUs = new HashSet<UserOrganizationUnit>();
        }

        public long CompanyId { get; set; }
        public long OrganizationUnitId { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<BIADocument> BIADocuments { get; set; }
        public virtual ICollection<BIAProcess> BIAProcesses { get; set; }
        public virtual ICollection<BIAWorkUnit> BIAWorkUnits { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<UserOrganizationUnit> UserOUs { get; set; }
    }
}
