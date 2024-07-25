using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTime")]
        public Time Get()
        {
            return new Time
            {
                time = DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss")
            };
        }
    }
}
