using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoDotNetCoreAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("[action]")]
        [HttpGet]
        public string GetName()
        {
            return "jamal";
        }
        [Route("kamal")]
        [HttpPost]
        public string PostName()
        {
            return "kamal";
        }
    }
}
