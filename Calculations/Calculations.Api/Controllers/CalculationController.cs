using Calculations.Common;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Calculations.Api.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class CalculationController : ControllerBase
    {
        private ICalculationService _calculationService;
        public CalculationController(ICalculationService calculationService) {
            _calculationService = calculationService;
        }

        [HttpGet]
        public IActionResult GetTeachingAssistantStudents(long termId)
        {
            return Ok(_calculationService.GetTeachingAssistantStudents(termId));
        }
    }
}
