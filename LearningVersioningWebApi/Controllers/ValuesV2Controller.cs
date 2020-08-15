using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningVersioningWebApi.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/Values")]
    [ApiController]
    public class ValuesV2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value two from api version", "Two" };
        }
    }
}
