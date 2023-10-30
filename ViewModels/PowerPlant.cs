using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace powerplantChallenge.Soutrani.Api.ViewModels
{
    public class PowerPlant
    {
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PowerPlantType Type { get; set; }
        public decimal Efficiency { get; set; }
        public decimal PMin { get; set; }
        public decimal PMax { get; set; }
    }
}
