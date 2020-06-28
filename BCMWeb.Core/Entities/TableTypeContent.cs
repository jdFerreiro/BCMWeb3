using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TableTypeContent
    {
        public TableTypeContent()
        {
            TableTypeContentCultures = new HashSet<TableTypeContentCulture>();
        }

        public int TableTypeContentId { get; set; }

        public virtual ICollection<TableTypeContentCulture> TableTypeContentCultures { get; set; }
    }
}
