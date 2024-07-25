using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DaysDifferenceController : Controller
    {
        private readonly ILogger<DaysDifferenceController> _logger;

        public DaysDifferenceController(ILogger<DaysDifferenceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDaysDifference")]
        public int Get(DateTime date)
        {
            DateTime today = DateTime.Today;
            TimeSpan difference = today - date;
            return Math.Abs(difference.Days);
        }
    }
}
