using Final_v1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_v1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VinylCollection_Controller : ControllerBase
    {
        private readonly ILogger<VinylCollection_Controller> _logger;
        private readonly Finalcontext _context;
        public VinylCollection_Controller(ILogger<VinylCollection_Controller> logger, Finalcontext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.VinylCollection.ToList());
        }

        [HttpGet("artist")]
        public IActionResult GetVinylByArtist(string artist)
        {
            var vinyl = _context.GetVinylByArtist(artist);
            if (vinyl.ToList().Count() == 0)
                return NotFound();
            if (vinyl != null)
            {
                return Ok(vinyl);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult InsertTeam(FootballTeam team)
        {
            try
            {
                _db.AddNewFootballTeam(team);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }
            return Created("", team);
        }

        [HttpPut]
        public IActionResult UpdateTeam(FootballTeam team)
        {
            var result = _db.UpdateFootballTeam(team);
            if (result == null)
                return NotFound();
            return Ok(team);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteTeamById(int id)
        {
            try
            {
                var deletedTeam = _context.DeleteFootballTeam(id);
                if (deletedTeam == null)
                    return NotFound();
                return Ok(deletedTeam);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}