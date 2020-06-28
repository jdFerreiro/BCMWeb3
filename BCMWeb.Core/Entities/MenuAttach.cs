using System;

namespace BCMWeb.Core.Entities
{
    public partial class MenuAttach
    {
        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public bool ForBussiness { get; set; }
        public long AttachId { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public bool? IsFolder { get; set; }
        public byte[] Data { get; set; }
        public DateTime? LastWriteTime { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
