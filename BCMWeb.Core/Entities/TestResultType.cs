using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TestResultType
    {
        public TestResultType()
        {
            TestResultTypeCultures = new HashSet<TestResultTypeCulture>();
        }

        public int TestResultTypeId { get; set; }

        public virtual ICollection<TestResultTypeCulture> TestResultTypeCultures { get; set; }
    }
}
