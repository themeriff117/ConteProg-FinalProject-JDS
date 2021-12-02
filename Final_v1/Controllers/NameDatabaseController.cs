using Final_v1.Data;
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
            private readonly ILogger<NameDatabaseController> _logger;
            private readonly FinalDatabase _context; 

            public NameDatabaseController(ILogger<NameDatabaseController> logger,  FinalDatabase context)
            {
                _logger = logger;
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_context.GetNameDatabase());
            }
        [HttpDelete("id")]
        public IActionResult GetByNameId(int id)
        {
            var name = _context.GetById(id);
            if (name.ToList().Count() == 0)
            {
                return NotFound();
            }
            if (name != null)
            {
                return Ok(name);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNameDatabasel(NameDatabase nameDatabase)
        {
            try
            {
                _context.AddNameDatabase(nameDatabase);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }
            return Created("", nameDatabase);
        }

        [HttpPut]
            public IActionResult UpdateNameDatabase(NameDatabase Name)
            {
                var result = _context.UpdateNameDatabase(Name);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok();
            }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NameDatabase))]

        public IActionResult DeletebyName(String Name) 
        {
            try 
            {
                var deletedName = _context.DeleteNameDatabase(Name);
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
