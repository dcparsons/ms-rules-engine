using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine.crm
{
    public class Vehicle : IVehicle
    {
        public int Year { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public string Type { get; set; }
    }
}
