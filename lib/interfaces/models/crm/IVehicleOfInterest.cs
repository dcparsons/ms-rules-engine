using System;

namespace ms_rules_engine.crm
{
    public interface IVehicleOfInterest
    {
        Guid? ID { get; set; }
        string Note { get; set; }
        IVehicle Vehicle { get; set; }
    }
}