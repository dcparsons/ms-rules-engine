using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.crm
{
    public class Opportunity : IOpportunity
    {
        public Guid ID { get; set; }
        public IVehicleOfInterest VehicleOfInterest { get; set; }
        public int StatusId { get; set; }
        public int? PriorityTypeId { get; set; }
        public Guid BooksId { get; set; }
        public IList<ILead> Leads { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
