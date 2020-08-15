using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LearningVersioningWebApi.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/weatherforecast")]
    public class WeatherForecast2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value two from the api version", "two" };
        }
    }
}
