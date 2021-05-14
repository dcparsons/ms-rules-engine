using ms_rules_engine.crm;
using ms_rules_engine.workflow;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ms_rules_engine.data
{
    public class Repo : IRepo
    {
        public IWorkflow GetWorkflow(IMessage<ICRMMessage> message)
        {
            return PopulateMockDB().First(x => x.BookId == message.BookId);
        }

        private IEnumerable<IWorkflow> PopulateMockDB()
        {
            var workflow = new Workflow
            {
                BookId = new Guid("37A325E6-4C83-4E8C-A1BA-210105B67F82"),
                TriggeredBy = "OpportunityAssigned",
                Name = "NewLead",
                Steps = new[]
                {
                    new WorkflowStep
                    {
                        DelayMetric = WaitMetric.Immediate,
                        StepKey = new Guid("2076EA3B-35BC-425F-A7AC-9B74D77DD4DF"),
                        Wait = false,
                        DelayMetricValue = null,
                        StepSequence = 1,
                        Rules = new []
                        {
                            new WorkflowRules()
                            {
                                WorkflowName = "NewLead-Immediate",
                                Rules = new List<Rule>()
                                {
                                    new Rule()
                                    {
                                        RuleName="LateNightEmail",
                                        ErrorMessage = "Message does not qualify for LateNightEmail",
                                        RuleExpressionType = RuleExpressionType.LambdaExpression,
                                        LocalParams = new[]
                                        {
                                            new ScopedParam
                                            {
                                                Name = "date1",
                                                Expression = @"DateTime.Parse(""21:00:00"")"
                                            },
                                            new ScopedParam
                                            {
                                                Name = "date2",
                                                Expression = @"DateTime.Parse(""08:59:59"")"
                                            },
                                        },
                                        Expression = @"input1.InsertDate.TimeOfDay.Ticks >= date1.TimeOfDay.Ticks && input1.InsertDate.TimeOfDay.Ticks <= date2.TimeOfDay.Ticks"

                                    },
                                    new Rule()
                                    {
                                        RuleName="GenericEmail",
                                        ErrorMessage = "Message does not qualify for GenericEmail",
                                        RuleExpressionType = RuleExpressionType.LambdaExpression,
                                        LocalParams = new[]
                                        {
                                            new ScopedParam
                                            {
                                                Name = "date1",
                                                Expression = @"DateTime.Parse(""09:00:00"")"
                                            },
                                            new ScopedParam
                                            {
                                                Name = "date2",
                                                Expression = @"DateTime.Parse(""20:59:59"")"
                                            },
                                        },
                                        Expression = @"input1.InsertDate.TimeOfDay.Ticks >= date1.TimeOfDay.Ticks && input1.InsertDate.TimeOfDay.Ticks <= date2.TimeOfDay.Ticks"

                                    },
                                    new Rule()
                                    {
                                        RuleName="AutoTrader",
                                        ErrorMessage = "Message does not qualify for AutoTrader",
                                        RuleExpressionType = RuleExpressionType.LambdaExpression,
                                        LocalParams = new[]
                                        {
                                            new ScopedParam
                                            {
                                                Name = "date1",
                                                Expression = @"DateTime.Parse(""09:00:00"")"
                                            },
                                            new ScopedParam
                                            {
                                                Name = "date2",
                                                Expression = @"DateTime.Parse(""20:59:59"")"
                                            },
                                        },
                                        Expression = @"input2.LeadSource == ""AutoTrader"" && input3.Vehicle.Type == ""Used"" && input1.InsertDate.TimeOfDay.Ticks >= date1.TimeOfDay.Ticks && input1.InsertDate.TimeOfDay.Ticks <= date2.TimeOfDay.Ticks"

                                    },

                                }
                            }
                        },

                    }
                }
            };
            return new[] { workflow };
        }
    }
}
