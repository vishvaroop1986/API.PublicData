using LundSchoolLocations.Helper;
using LundSchoolLocations.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChargingStationsSweden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolLocationDataController : ControllerBase
    {
        private ILocationOperations _locationOperations;
        public SchoolLocationDataController(ILocationOperations locationOperations )
        {
            _locationOperations = locationOperations;
        }
        // GET: api/<SchoolLocationDataController>
        [HttpGet]
        public async Task<SchoolData> GetAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage _response = await client.GetAsync("https://katalog.lund.se/rowstore/dataset/b028991c-2e85-4b6c-97a8-9afc2dc18016?_limit=100&_offset=100");
            string responseBody = await _response.Content.ReadAsStringAsync();
            SchoolData _localData = new SchoolData();
            _localData = JsonConvert.DeserializeObject<SchoolData>(responseBody);

            return _localData;
        }

        // GET api/<SchoolLocationDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SchoolLocationDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SchoolLocationDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
            
        // DELETE api/<SchoolLocationDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
