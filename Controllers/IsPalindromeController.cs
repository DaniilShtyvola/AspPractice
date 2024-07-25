using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IsPalindromeController : ControllerBase
    {
        private readonly ILogger<IsPalindromeController> _logger;

        public IsPalindromeController(ILogger<IsPalindromeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPalindrome")]
        public bool Get(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
