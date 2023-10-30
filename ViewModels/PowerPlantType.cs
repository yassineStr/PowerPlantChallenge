using System.Runtime.Serialization;

namespace powerplantChallenge.Soutrani.Api.ViewModels
{
    public enum PowerPlantType
    {
        [EnumMember(Value = "gasfired")]
        GasFired = 0,
        [EnumMember(Value = "turbojet")]
        TurboJet = 1,
        [EnumMember(Value = "windturbine")]
        WindTurbine = 2
    }
}
