using ms_rules_engine.workflow;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.data
{
    public interface IRepo
    {
        IWorkflow GetWorkflow(IMessage<ICRMMessage> message); 
    }
}
