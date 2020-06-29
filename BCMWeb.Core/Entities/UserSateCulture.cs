namespace BCMWeb.Core.Entities
{
    public class UserSateCulture : BaseEntity
    {
        public string Culture { get; set; }
        public short UserStateId { get; set; }
        public string Description { get; set; }

        public virtual UserState UserStateInfo { get; set; }
    }
}
