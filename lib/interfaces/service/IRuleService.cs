using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.service
{
    public interface IRuleService
    {
        void EvaluateRule(IMessage<ICRMMessage> message);
    }
}
