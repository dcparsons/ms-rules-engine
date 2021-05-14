using ms_rules_engine.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine
{
    public class CRMMessage : ICRMMessage
    {
        public IOpportunity Opportunity { get; set; }
        public string TriggeredBy { get; set; }
        public Guid? LastGroupExecuted { get; set; }
        public Guid? GroupToExecute { get; set; }
    }
}
