using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.workflow
{
    public class Workflow : IWorkflow
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string TriggeredBy { get; set; }
        public IEnumerable<IWorkflowStep> Steps { get; set; }
    }
}
