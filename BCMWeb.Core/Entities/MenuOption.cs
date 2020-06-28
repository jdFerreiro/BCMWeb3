using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class MenuOption
    {
        public MenuOption()
        {
            DocumentContents = new HashSet<DocumentContent>();
            UserMenuLevels = new HashSet<MenuLevelUser>();
            UserMenuOptions = new HashSet<UserMenuOption>();
            PMTMessageUpdates = new HashSet<PMTMessageUpdate>();
            PMTSchedules = new HashSet<PMTSchedule>();
            PMTScheduleDocuments = new HashSet<PMTScheduleDocument>();
            PMTResponsibleUpdates = new HashSet<PMTUpdateResponsable>();
        }

        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public int? CodeId { get; set; }
        public long ParentId { get; set; }
        public short ElementTypeId { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageRoot { get; set; }
        public bool IsActive { get; set; }
        public bool ForBussiness { get; set; }
        public bool ForTechnology { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual CompanyMenuOption CompanyMenuOption { get; set; }
        public virtual ICollection<DocumentContent> DocumentContents { get; set; }
        public virtual ICollection<MenuLevelUser> UserMenuLevels { get; set; }
        public virtual ICollection<UserMenuOption> UserMenuOptions { get; set; }
        public virtual ICollection<PMTMessageUpdate> PMTMessageUpdates { get; set; }
        public virtual ICollection<PMTSchedule> PMTSchedules { get; set; }
        public virtual ICollection<PMTScheduleDocument> PMTScheduleDocuments { get; set; }
        public virtual ICollection<PMTUpdateResponsable> PMTResponsibleUpdates { get; set; }
    }
}
