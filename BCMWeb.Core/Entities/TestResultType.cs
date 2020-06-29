using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class TestResultType : BaseEntity
    {
        public TestResultType()
        {
            TestResultTypeCultures = new HashSet<TestResultTypeCulture>();
        }

        public int TestResultTypeId { get; set; }

        public virtual ICollection<TestResultTypeCulture> TestResultTypeCultures { get; set; }
    }
}
