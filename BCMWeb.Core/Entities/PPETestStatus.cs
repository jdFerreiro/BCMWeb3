using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class PPETestStatus : BaseEntity
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
