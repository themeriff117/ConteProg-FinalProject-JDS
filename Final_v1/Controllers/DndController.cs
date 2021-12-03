using Final_v1.Data;
using Final_v1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DndController : ControllerBase
    {
        private readonly ILogger<DndController> _logger;
        private readonly FinalDatabase _context;
        public DndController(ILogger<DndController> logger, FinalDatabase context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetDnD());
        }
        [HttpDelete("id")]
        public IActionResult GetByDndId(int id)
        {
            var dnd = _context.GetByDnDId(id);
            if (dnd.ToList().Count() == 0)
            {
                return NotFound();
            }
            if (dnd != null)
            {
                return Ok(dnd);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddNewDnd(DnD dnd)
        {
            try
            {
                _context.AddNewDnD(dnd);
            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }
            return Created("", dnd);
        }

        [HttpPut]
        public IActionResult UpdateDnD(DnD dnd)
        {
            var result = _context.UpdateDnD(dnd);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(dnd);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult DeleteDnD(string Name)
        {
            try
            {
                var deleteddnd = _context.DeleteDnD(Name);
                if (deleteddnd == null)
                {
                    return NotFound();
                }
                return Ok(deleteddnd);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}