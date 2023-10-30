using AutoMapper;
using System;
using powerplantChallenge.Soutrani.Api.ViewModels;
using DataModels = PowerPlant.Services.DataModels;

namespace powerplantChallenge.Soutrani.Api.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<ViewModels.PowerPlant, DataModels.PowerPlant>().ReverseMap();
            CreateMap<PowerPlantType, DataModels.PowerPlantType>().ReverseMap();
            CreateMap<Fuel, DataModels.Fuel>().ReverseMap();
        }
    }
}
