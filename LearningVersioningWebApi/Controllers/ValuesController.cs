using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningVersioningWebApi.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{v:apiversion}/Values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value one from api version", "One" };
        }
    }
}
