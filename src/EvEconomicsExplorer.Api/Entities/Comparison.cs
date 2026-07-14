namespace EvEconomicsExplorer.Api.Entities
{
    public class Comparison
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public double AnnualMileage { get; set; }
        public decimal CurrentFuelPrice { get; set; }
        public decimal ElectricityPrice { get; set; }
        public double CurrentVehicleMpg { get; set; }
        public double EvMilesPerKwh { get; set; }
    }
}
