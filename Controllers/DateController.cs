using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateController : ControllerBase
    {
        private readonly ILogger<DateController> _logger;

        public DateController(ILogger<DateController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDate")]
        public Date Get()
        {
            return new Date
            {
                date = DateOnly.FromDateTime(DateTime.Now),
            };
        }
    }
}
