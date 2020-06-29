using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class TableTypeContent : BaseEntity
    {
        public TableTypeContent()
        {
            TableTypeContentCultures = new HashSet<TableTypeContentCulture>();
        }

        public int TableTypeContentId { get; set; }

        public virtual ICollection<TableTypeContentCulture> TableTypeContentCultures { get; set; }
    }
}
