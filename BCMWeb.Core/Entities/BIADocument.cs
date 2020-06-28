using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class BIADocument
    {
        public BIADocument()
        {
            BIAComments = new HashSet<BIAComment>();
            BIAProcesses = new HashSet<BIAProcess>();
        }

        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long? DocumentId { get; set; }
        public long? OUId { get; set; }
        public long? ServiceChainId { get; set; }
        public long? DocumentTypeId { get; set; }

        public virtual OrganizationUnit OUInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
        public virtual ICollection<BIAComment> BIAComments { get; set; }
        public virtual ICollection<BIAProcess> BIAProcesses { get; set; }
    }
}
