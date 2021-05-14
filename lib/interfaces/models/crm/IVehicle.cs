namespace ms_rules_engine.crm
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string Type { get; set; }
    }
}