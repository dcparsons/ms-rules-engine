using ms_rules_engine.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine
{
    public interface ICRMMessage
    {
        IOpportunity Opportunity { get; set; }
        string TriggeredBy { get; set; }
        Guid? LastGroupExecuted { get; set; }
        Guid? GroupToExecute { get; set; }
    }
}
