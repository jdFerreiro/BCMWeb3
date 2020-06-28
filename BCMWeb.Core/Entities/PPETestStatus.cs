using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PPETestStatus
    {
        public PPETestStatus()
        {
            PPETestStatusCultures = new HashSet<PPETestStatusCulture>();
            PPETestExecutionExercises = new HashSet<PPETestExecutionExercise>();
        }

        public short StatusId { get; set; }

        public virtual ICollection<PPETestStatusCulture> PPETestStatusCultures { get; set; }
        public virtual ICollection<PPETestExecutionExercise> PPETestExecutionExercises { get; set; }
    }
}
