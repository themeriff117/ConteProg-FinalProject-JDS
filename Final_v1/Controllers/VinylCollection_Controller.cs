using Final_v1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_v1.Models;

namespace Final_v1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VinylCollection_Controller : ControllerBase
    {
        private readonly ILogger<VinylCollection_Controller> _logger;
        private readonly FinalDatabase _context;
        public VinylCollection_Controller(ILogger<VinylCollection_Controller> logger, FinalDatabase context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllVinyls());
        }

        [HttpPost]
        public IActionResult AddNewVinyl(Vinyl vinyls)
        {
            try
            {
                _context.AddNewVinyl(vinyls);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }
            return Created("", vinyls);
        }

        [HttpPut]
        public IActionResult UpdateVinylCollection(Vinyl vinyls)
        {
            var result = _context.UpdateVinylCollection(vinyls);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(vinyls);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        
        public IActionResult DeleteVinyl(string artist)
        {
            try
            {
                var deletedVinyl = _context.DeleteVinyl(artist);
                if (deletedVinyl == null)
                {
                    return NotFound();
                }
                return Ok(deletedVinyl);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
