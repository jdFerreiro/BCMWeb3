namespace BCMWeb.Core.Entities
{
    public class PPETestStatusCulture : BaseEntity
    {
        public string Cultura { get; set; }
        public short StatusId { get; set; }
        public string Description { get; set; }

        public virtual PPETestStatus PPETestStatusInfo { get; set; }
    }
}
