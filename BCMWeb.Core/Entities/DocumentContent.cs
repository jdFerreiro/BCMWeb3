using System;

namespace BCMWeb.Core.Entities
{
    public partial class DocumentContent
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long MenuOptionId { get; set; }
        public byte[] BinaryContent { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
    }
}
