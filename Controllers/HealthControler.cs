using Microsoft.AspNetCore.Mvc;

namespace DemoNetCoreService.Controllers
{
    [Route("api/health")]
    public class HealthController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "OK";
        }
    }
}