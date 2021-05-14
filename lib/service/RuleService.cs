using ms_rules_engine.data;
using Newtonsoft.Json;
using RulesEngine;
using RulesEngine.Models;
using RulesEngine.Extensions;
using System.Collections.Generic;
using System;

namespace ms_rules_engine.service
{
    public class RuleService : IRuleService
    {
        private IRepo repo = new Repo();
        
        public void EvaluateRule(IMessage<ICRMMessage> message)
        {
            var wflw = repo.GetWorkflow(message);

            foreach(var stp in wflw.Steps)
            {
                //var lst = JsonConvert.DeserializeObject<List<WorkflowRules>>(stp.JsonRules);
                var bre = new RulesEngine.RulesEngine(stp.Rules, null);

                var result = bre.ExecuteAllRulesAsync("NewLead-Immediate", message.Payload.Opportunity, message.Payload.Opportunity.Leads[0], message.Payload.Opportunity.VehicleOfInterest).Result;
                
                result.OnSuccess((eventName) => {
                    Console.WriteLine($"NewLead-Immediate evaluation resulted in succees - {eventName}");
                }).OnFail(() => {
                    Console.WriteLine($"NewLead-Immediate evaluation resulted in failure");
                });
            }
            

        }
    }
}
