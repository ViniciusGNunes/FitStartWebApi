using FitStartWebApi.Models;
using FitStartWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private readonly CalculationServices _calculatorService;
        public CalculationsController(CalculationServices calculationServices) 
        {
            _calculatorService = calculationServices;
        }

        [HttpPost("/calories")]
        public IActionResult PostCalories([FromBody] CalorieCalcModel model) 
        {
            if (model is null) 
                return BadRequest();

            return Ok((int)_calculatorService.CalculateCalories(model));
        }
    }
}
