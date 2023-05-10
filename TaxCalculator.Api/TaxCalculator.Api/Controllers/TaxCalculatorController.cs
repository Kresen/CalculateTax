using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxCalculator.Dtos;
using TaxCalculator.Services.Interfaces;

namespace TaxCalculator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxCalculatorController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;

        public TaxCalculatorController(ITaxCalculatorService taxCalculatorService)
        {
            _taxCalculatorService = taxCalculatorService;
        }

        [HttpPost(Name = "CalculateTax")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<decimal>> CalculateTax(TaxCalculatorDTO input)
        {
            if (input == null)
            {
                return BadRequest();
            }

            return await _taxCalculatorService.CalculateTax(input);
        }
    }
}
