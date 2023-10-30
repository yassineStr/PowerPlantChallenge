namespace powerplantChallenge.Soutrani.Api.ViewModels
{
    public class PayloadRequest
    {
        public decimal Load { get; set; }
        public Fuel Fuels { get; set; }
        public IEnumerable<PowerPlant> PowerPlants { get; set; }
    }
}
