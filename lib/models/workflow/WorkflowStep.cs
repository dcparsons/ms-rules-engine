using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.workflow
{
    public class WorkflowStep : IWorkflowStep
    {
        public Guid StepKey { get; set; }
        public int StepSequence { get; set; }
        public bool Wait { get; set; }
        public WaitMetric DelayMetric { get; set; }
        public int? DelayMetricValue { get; set; }
        public string JsonRules { get; set; }
        public WorkflowRules[] Rules { get; set; }
    }
}
