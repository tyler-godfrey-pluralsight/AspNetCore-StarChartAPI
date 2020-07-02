using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var obj = _context.CelestialObjects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.CelestialObjects.
            return Ok(obj);
        }
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var obj = _context.CelestialObjects.Find(name);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.CelestialObjects);
        }
    }
}
