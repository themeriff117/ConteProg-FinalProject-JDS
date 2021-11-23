using Microsoft.AspNetCore.Http;
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

            [HttpPut]
            public IActionResult UpdateName(NameDatabase Name)
            {
                var result = NameDatabase.UpdateName(Name);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok();
            }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NameDatabase))]
        public IActionResult DeletebyName(Name) 
        {
            try 
            {
                var deletedName = NameDatabase.DeleteName(Name);
                if (deletedName == null)
                    return NotFound();
                return Ok(deletedName);
            } 
            catch (Exception) 
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
