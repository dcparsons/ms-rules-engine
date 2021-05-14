using System;
using System.Collections.Generic;

namespace ms_rules_engine.crm
{
    public interface IOpportunity
    {
        Guid ID { get; set; }
        Guid BooksId { get; set; }
        DateTime InsertDate { get; set; }
        IList<ILead> Leads { get; set; }
        int? PriorityTypeId { get; set; }
        int StatusId { get; set; }
        DateTime? UpdateDate { get; set; }
        IVehicleOfInterest VehicleOfInterest { get; set; }
    }
}