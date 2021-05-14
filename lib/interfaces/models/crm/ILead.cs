using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ms_rules_engine.crm
{
    public interface ILead
    {
        Guid Id { get; set; }
        DateTime InsertDate { get; set; }
        bool? IsLeadAdfGenerated { get; set; }
        bool? IsLeadAdfProcessed { get; set; }
        XDocument LeadAdf { get; set; }
        DateTime? LeadAdfProcessDate { get; set; }
        string LeadRequest { get; set; }
        string LeadSource { get; set; }
        string Note { get; set; }
        IOpportunity Opportunity { get; set; }
        DateTime? UpdateDate { get; set; }
        IList<IVehicleOfInterest> VehiclesOfInterest { get; set; }
    }
}