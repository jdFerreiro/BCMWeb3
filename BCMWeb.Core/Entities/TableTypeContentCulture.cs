namespace BCMWeb.Core.Entities
{
    public class TableTypeContentCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int TableTypeContentId { get; set; }
        public string Description { get; set; }

        public virtual TableTypeContent TableTypeContentInfo { get; set; }
    }
}
