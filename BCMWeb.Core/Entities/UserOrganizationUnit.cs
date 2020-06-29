namespace BCMWeb.Core.Entities
{
    public class UserOrganizationUnit : BaseEntity
    {
        public long CompanyId { get; set; }
        public long UserId { get; set; }
        public long LevelUserId { get; set; }

        public long OrganizationUnitId { get; set; }

        public virtual OrganizationUnit OrganizationUnitInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual UserLevel UserLevelInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
