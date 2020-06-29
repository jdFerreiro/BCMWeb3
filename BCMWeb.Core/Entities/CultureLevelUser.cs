namespace BCMWeb.Core.Entities
{
    public class CultureLevelUser : BaseEntity
    {
        public string Culture { get; set; }
        public long LevelUserId { get; set; }
        public string Description { get; set; }

        public virtual UserLevel LevelUserInfo { get; set; }
    }
}
