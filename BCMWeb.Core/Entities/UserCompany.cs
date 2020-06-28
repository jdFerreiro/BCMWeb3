using System;

namespace BCMWeb.Core.Entities
{
    public partial class UserCompany
    {
        public long CompanyId { get; set; }
        public long UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public long LevelUserId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual UserLevel UserLevelInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
