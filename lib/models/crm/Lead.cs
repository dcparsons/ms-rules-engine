using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ms_rules_engine.crm
{
    public class Lead : ILead
    {
        public Lead()
        {
            VehiclesOfInterest = new List<IVehicleOfInterest>();
        }

        public virtual Guid Id { get; set; }
        public virtual string LeadSource { get; set; }
        public virtual string LeadRequest { get; set; }
        public virtual DateTime InsertDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual string Note { get; set; }
        public virtual XDocument LeadAdf { get; set; }
        public virtual bool? IsLeadAdfProcessed { get; set; }
        public virtual DateTime? LeadAdfProcessDate { get; set; }
        public virtual bool? IsLeadAdfGenerated { get; set; }
        public virtual IList<IVehicleOfInterest> VehiclesOfInterest { get; set; }
        public virtual IOpportunity Opportunity { get; set; }
    }
}
