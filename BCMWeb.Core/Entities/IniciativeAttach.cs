using System;

namespace BCMWeb.Core.Entities
{
    public class IniciativeAttach : BaseEntity
    {
        public long CompanyId { get; set; }
        public long IniciativeId { get; set; }
        public long AttachId { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
