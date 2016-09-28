using System.Threading.Tasks;
using DemoNetCoreService.Services;
using Microsoft.AspNetCore.Mvc;


namespace DemoNetCoreService.Controllers
{ 
    [Route("api/demo")]
    public class PersonController : Controller
    {
        [HttpGet("{name}")]
        public async Task<dynamic> Get(string name, [FromServices]CouchDb couchDb)
        {
            return await couchDb.GetDocument(name);
        }

        [HttpPut("{name}")]
        public async Task Put(string name, [FromBody] dynamic person, [FromServices]CouchDb couchDb)
        {
            await couchDb.PutDocument(name, person);
        }
    }
}