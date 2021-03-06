﻿namespace BCMWeb.Core.Entities
{
    public class Provider : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ProviderId { get; set; }
        public string Name { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
