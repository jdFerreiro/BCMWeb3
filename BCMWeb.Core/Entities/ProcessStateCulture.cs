namespace BCMWeb.Core.Entities
{
    public partial class ProcessStateCulture
    {
        public string Culture { get; set; }
        public long ProcessStateId { get; set; }
        public string Description { get; set; }

        public virtual ProcessState ProcessStateInfo { get; set; }
    }
}
