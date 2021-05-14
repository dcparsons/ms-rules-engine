using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.crm
{
    public class VehicleOfInterest : IVehicleOfInterest
    {
        public Guid? ID { get; set; }
        public string Note { get; set; }
        public IVehicle Vehicle { get; set; }
        
    }
}
