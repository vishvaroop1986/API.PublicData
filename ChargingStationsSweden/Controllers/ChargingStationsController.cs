using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChargingStationsSweden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargingStationsController : ControllerBase
    {
        // GET: api/<ChargingStationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChargingStationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChargingStationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChargingStationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChargingStationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
