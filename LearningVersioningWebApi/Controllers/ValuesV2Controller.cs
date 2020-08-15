using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningVersioningWebApi.Controllers
{
    [ApiVersion("2")]
    [Route("api/v{v:apiversion}/Values")]
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
