using System;
using System.Collections.Generic;


namespace ms_rules_engine.workflow
{
    public interface IWorkflow
    {
        Guid BookId { get; set; }
        string Name { get; set; }
        string TriggeredBy { get; set; }
        IEnumerable<IWorkflowStep> Steps { get; set; }
    }
}
