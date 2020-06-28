namespace BCMWeb.Core.Entities
{
    public partial class UserMenuOption
    {
        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public long UserId { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
