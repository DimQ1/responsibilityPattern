using System.Collections.Generic;

namespace Patterns
{
    public class Requirement
    {
        public List<string> OperationsDone { get; set; }

        public Requirement()
        {
            this.OperationsDone = new List<string>();
        }
    }
}