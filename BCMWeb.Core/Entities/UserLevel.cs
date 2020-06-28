using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class UserLevel
    {
        public UserLevel()
        {
            UserLevelCultures = new HashSet<CultureLevelUser>();
            UserCompanys = new HashSet<UserCompany>();
            UserLevelMenuOptions = new HashSet<MenuLevelUser>();
            UserOUs = new HashSet<UserOrganizationUnit>();
        }

        public long LevelUserId { get; set; }
        public bool AllDocs { get; set; }
        public string UserRole { get; set; }

        public virtual ICollection<CultureLevelUser> UserLevelCultures { get; set; }
        public virtual ICollection<UserCompany> UserCompanys { get; set; }
        public virtual ICollection<MenuLevelUser> UserLevelMenuOptions { get; set; }
        public virtual ICollection<UserOrganizationUnit> UserOUs { get; set; }
    }
}
