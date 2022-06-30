using EpicPatientAPI.Model.Model;
using EpicPatientAPI.Services.Iservices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EpicPatientAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpicController : ControllerBase
    {
        private IEpicService _epicService;
        public EpicController(IEpicService epicService)
        {
            _epicService = epicService;
        }

        [HttpGet]
        [Route("GetAuthToken")]
        public async Task<Response<epictoken>> GetAuthToken()
        {
            return await _epicService.GetAuthToken();
        }

        [HttpGet]
        [Route("GetPatientByMRN")]
        public async Task<Response<PatientDemographicsResponse>> GetPatientByMRN(string mrn)
        {
            return await _epicService.GetPatientByMRN(mrn);
        }
    }
}
