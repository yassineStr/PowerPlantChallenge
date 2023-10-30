using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PowerPlant.Services;
using powerplantChallenge.Soutrani.Api.ViewModels;

namespace powerplantChallenge.Soutrani.Api.Controllers
{
    [ApiController]
    public class PowerPlantController : ControllerBase
    {
        private readonly IPowerPlantService _iPowerPlantService;
        private readonly IMapper _mapper; 
        private readonly ILogger<PowerPlantController> _logger;

        public PowerPlantController(IPowerPlantService iPowerPlantService, IMapper mapper, ILogger<PowerPlantController> logger)
        {
            _iPowerPlantService = iPowerPlantService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Calcul Unit commitment
        /// </summary>
        [HttpPost]
        [Route("api/calculateUnit-Commitment")]
        public IActionResult CalculateUnitCommitment([FromBody] PayloadRequest request)
        {
            try
            {
                var mappedPowerPlants = request.PowerPlants.Select(x => _mapper.Map<PowerPlant.Services.DataModels.PowerPlant>(x));
                var mappedFuel = _mapper.Map<PowerPlant.Services.DataModels.Fuel>(request.Fuels);
                return Ok(_iPowerPlantService.GetProductionPlan(mappedPowerPlants, mappedFuel, request.Load));

            }
            catch (Exception e)
            {
                _logger.LogError($"Une erreur est survenue lors du calcul. Exception : '{e.Message}'");
                throw;
            }
        }
    }
}
