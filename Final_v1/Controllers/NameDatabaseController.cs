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
    public class NameDatabaseController : Controller
    {
        readonly ILogger<NameDatabaseController> _logger;

            public NameDatabaseController(ILogger<NameDatabaseController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(new NameDatabase { Name = "Sam"});
            }
        }
    }
}
