﻿using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class Month
    {
        public Month()
        {
            BIABigImpact = new HashSet<BIABigImpact>();
            MonthCultures = new HashSet<MonthCulture>();
        }

        public int MonthId { get; set; }

        public virtual ICollection<BIABigImpact> BIABigImpact { get; set; }
        public virtual ICollection<MonthCulture> MonthCultures { get; set; }
    }
}
