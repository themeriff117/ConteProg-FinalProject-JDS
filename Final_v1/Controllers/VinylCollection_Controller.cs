using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinylCollection_Controller : ControllerBase
    {
        // GET: api/<VinylCollection_Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VinylCollection_Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VinylCollection_Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VinylCollection_Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VinylCollection_Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
