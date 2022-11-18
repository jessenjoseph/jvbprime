using JVBWebApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace JVBWebApp.Controllers
{
    [ApiController]
    [Route("jvbapi/[controller]")]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly IPrimeNumbersGetter _getter;

        public PrimeNumbersController(IPrimeNumbersGetter getter)
        {
            _getter = getter ?? throw new ArgumentNullException(nameof(getter));
        }

        [HttpGet("{inputNumber}")]
        public ActionResult<IEnumerable<int>> GetPrimeNumbersBeforeGiven(int inputNumber)
        {
            if(inputNumber <= 0)
            {
                return NotFound("Please enter a positive and non-zero number");
            }

            return Ok(_getter.GetPrimeNumbersBeforeGivenNumber(inputNumber));
        }
    }
}