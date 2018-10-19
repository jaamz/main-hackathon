using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/messages")]
    [ApiController]
    public class postedmessageController : Controller
    {

        private HackathonDBContext _context;

        public postedmessageController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<PostedMessage> Get()
        {
            return _context.postedmessage.Include(m => m.thread_id).ToList();
        }

        [HttpGet("{id}", Name = "Getpostedmessage")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PostedMessage postedmessage = await _context.postedmessage
                                        .Include(m => m.message_id)
                                        .SingleOrDefaultAsync(m => m.message_id == id);

            if (postedmessage == null)
            {
                return NotFound();
            }

            return Ok(postedmessage);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostedMessage postedmessage)
        {
            if (postedmessage == null)
            {
                return BadRequest();
            }

            _context.postedmessage.Add(postedmessage);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            PostedMessage newpostedmessage = await _context.postedmessage
                                .Include(m => m.thread)
                                .SingleOrDefaultAsync(t => t.message_id == postedmessage.message_id);

            if (newpostedmessage == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("Getpostedmessage", new { id = postedmessage.message_id }, newpostedmessage);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PostedMessage postedmessage)
        {
            if (postedmessage == null || postedmessage.message_id != id)
            {
                return BadRequest();
            }

            _context.postedmessage.Update(postedmessage);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            PostedMessage item = _context.postedmessage.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.postedmessage.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
