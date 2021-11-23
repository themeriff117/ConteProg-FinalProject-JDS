using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DndController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DndController> _logger;

        public DndController(ILogger<DndController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<DndDatabase> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut]
        public IEnumerable<DndDatabase> Get() 
        { 
         //public IActionResult UpdateDnd(DndClass class)
         //IActionResult displays the

        }

        [HttpDelete]
        public IEnumerable<DndDatabase> Get()
        {
            _db.DeleteDndChar(char);
        }
    }
}

//Need database class to wrap context (another class)
//Context and database are a 1 to 1 relationship, meaning 1 context and 1 database 