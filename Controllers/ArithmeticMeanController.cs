using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArithmeticMeanController : ControllerBase
    {
        private readonly ILogger<ArithmeticMeanController> _logger;

        public ArithmeticMeanController(ILogger<ArithmeticMeanController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetArithmeticMean")]
        public double Get([FromQuery] List<int> array)
        {
            return array.Average();
        }
    }
}
