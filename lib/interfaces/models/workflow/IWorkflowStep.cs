using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.workflow
{
    public interface IWorkflowStep
    {
        Guid StepKey { get; set; }
        int StepSequence { get; set; }
        bool Wait { get; set; }
        WaitMetric DelayMetric { get; set; }
        int? DelayMetricValue { get; set; }
        string JsonRules { get; set; }
        WorkflowRules[] Rules { get; set; }
    }
}
