using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/collaboration")]
    [ApiController]
    public class CollaborationController : Controller
    {

        private HackathonDBContext _context;

        public CollaborationController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Collaboration> Get()
        {
            return _context.collaboration
                                .Include(t => t.appuser)
                                .ToList();
        }

        [HttpGet("{id}", Name = "GetThread")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Collaboration collaboration = await _context.collaboration
                                        .Include(t => t.appuser_id)
                                        .FirstOrDefaultAsync(t => t.collaboration_id == id);

            if (collaboration == null)
            {
                return NotFound();
            }

            return Ok(collaboration);

        }

             [HttpPost]
        public async Task<IActionResult> Post([FromBody] Collaboration collaboration)
        {
            if (collaboration == null)
            {
                return BadRequest();
            }

            _context.collaboration.Add(collaboration);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            Collaboration newThread = await _context.collaboration
                                        .Include(t => t.appuser_id)
                                        .FirstOrDefaultAsync(t => t.collaboration_id == collaboration.collaboration_id);
            
            if (newThread == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("GetThread", new {id = collaboration.collaboration_id }, newThread);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Collaboration collaboration)
        {
            if (collaboration == null || collaboration.collaboration_id != id)
            {
                return BadRequest();
            }

            _context.collaboration.Update(collaboration);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Collaboration item = _context.collaboration.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.collaboration.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
