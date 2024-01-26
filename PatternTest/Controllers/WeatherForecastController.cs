using Microsoft.AspNetCore.Mvc;
using PatternTest.Services;
using System.Diagnostics;

namespace PatternTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {
            DateTime dateTime = DateTime.Now;
            Debug.WriteLine(dateTime.ToString());
            DateTime dateTime2 = DateTime.UtcNow;
            Debug.WriteLine(dateTime2.ToLocalTime().ToString());

            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza("É`Å[ÉY");
            return new OkObjectResult(pizza);
        }
    }
}