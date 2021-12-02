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
    public class Anime_Controller: ControllerBase
    {
        private readonly ILogger<Anime_Controller> _logger;
        private readonly FinalDatabase _context;
        public Anime_Controller(ILogger<Anime_Controller> logger, FinalDatabase context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAnime());
        }
        [HttpDelete("id")]
        public IActionResult GetByAnimeId (int id)
        {
            var anime = _context.GetByAnimeId(id);
            if (anime.ToList().Count() == 0)
            {
                return NotFound();
            }
            if (anime != null)
            {
                return Ok(anime);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddNewAnime(Anime anime)
        {
            try
            {
                _context.AddNewAnime(anime);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
            return Created("", anime);
        }

        [HttpPut]
        public IActionResult UpdateAnime(Anime anime)
        {
            var result = _context.UpdateAnime(anime);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(anime);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult DeleteAnime(string Name)
        {
            try
            {
                var deletedAnime= _context.DeleteAnime(Name);
                if (deletedAnime == null)
                {
                    return NotFound();
                }
                return Ok(deletedAnime);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
