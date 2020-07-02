namespace BCMWeb.Core.Entities
{
    public class Security : BaseEntity
    {
        public long SecurityId { get; set; }
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string UserPassword { get; set; }
        public long RolId { get; set; }
    }
}
