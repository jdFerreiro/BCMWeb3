using System;

namespace BCMWeb.Core.Entities
{
    public partial class DocumentAttachment
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long AttachmentId { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public bool? IsFolder { get; set; }
        public byte[] Data { get; set; }
        public DateTime? LastWriteTime { get; set; }

        public virtual Document DocumentInfo { get; set; }
    }
}
