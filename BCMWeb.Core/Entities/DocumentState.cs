using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class DocumentState : BaseEntity
    {
        public DocumentState()
        {
            DocumentStateCultures = new HashSet<DocumentStateCulture>();
            Documents = new HashSet<Document>();
        }

        public long DocumentStateId { get; set; }

        public virtual ICollection<DocumentStateCulture> DocumentStateCultures { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
