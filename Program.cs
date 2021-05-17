using ms_rules_engine.crm;
using ms_rules_engine.service;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ms_rules_engine
{
    class Program
    {
        static void Main(string[] args)
        {


            var lst = GenerateMessage();
            var svc = new RuleService();

            foreach(var x in lst)
            {
                svc.EvaluateRule(x);
                break;
            }
            

            //Parallel.ForEach(lst, msg =>
            //{
            //    var svc = new RuleService();
            //    svc.EvaluateRule(msg);
            //});

        }

        private static IEnumerable<IMessage<ICRMMessage>> GenerateMessage()
        {
            var lst = new List<IMessage<ICRMMessage>>();
            for(var x = 0; x<= 100000; x++)
            {
                var msg = new Message<ICRMMessage>
                {
                    CompanyId = Guid.NewGuid(),
                    BookId = new Guid("37A325E6-4C83-4E8C-A1BA-210105B67F82"),
                    Payload = new CRMMessage
                    {
                        TriggeredBy = "OpportunityAssigned",
                        Opportunity = GenerateOpp()
                    }
                };
                lst.Add(msg);
            }
            

            return lst;
        }
        private static IOpportunity GenerateOpp()
        {
            return new Opportunity
            {
                ID = Guid.NewGuid(),
                BooksId = new Guid("37A325E6-4C83-4E8C-A1BA-210105B67F82"),
                InsertDate = DateTime.Now,
                Leads = new[] {
                    new Lead
                    {
                        IsLeadAdfGenerated = true,
                        LeadSource = "AutoTrader",
                        InsertDate = DateTime.Now,
                    },
                },
                VehicleOfInterest = new VehicleOfInterest
                {
                    Vehicle = new Vehicle
                    {
                        Make = "Ford",
                        Model = "F-150",
                        Year = 2018,
                        Type = "Used"
                    }
                }
            };
        }
    }
}
