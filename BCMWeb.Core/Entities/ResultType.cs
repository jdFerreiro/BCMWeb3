using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class ResultType : BaseEntity
    {
        public ResultType()
        {
            ResultTypeCultures = new HashSet<ResultTypeCulture>();
        }

        public int ResultTypeId { get; set; }

        public virtual ICollection<ResultTypeCulture> ResultTypeCultures { get; set; }
    }
}
