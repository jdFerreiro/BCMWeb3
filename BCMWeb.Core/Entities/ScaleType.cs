﻿using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class ScaleType
    {
        public ScaleType()
        {
            Scales = new HashSet<Scale>();
        }

        public long CompanyId { get; set; }
        public long ScaleTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Scale> Scales { get; set; }
    }
}
