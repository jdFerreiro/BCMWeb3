namespace BCMWeb.Core.Entities
{
    public class MenuLevelUser : BaseEntity
    {
        public long CompanyId { get; set; }
        public long UserLevelId { get; set; }
        public long MenuItemId { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual UserLevel UserLevelInfo { get; set; }
    }
}
