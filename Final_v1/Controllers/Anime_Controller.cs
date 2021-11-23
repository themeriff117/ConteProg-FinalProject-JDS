using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Anime_Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Anime {ID= "1" Name = "Konosuba" });
        }
        [HttpDelete]
        
    }
}
