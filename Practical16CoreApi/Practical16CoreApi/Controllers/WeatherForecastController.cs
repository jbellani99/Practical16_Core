using Microsoft.AspNetCore.Mvc;

namespace Practical16CoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> hello()
        {
            _logger.LogInformation("Api Call!");
            return "Hello World";
        }

    }
}