using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/threads")]
    [ApiController]
    public class ThreadController : Controller
    {

        private HackathonDBContext _context;

        public ThreadController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Thread> Get()
        {
            return _context.thread.Include(t => t.channel).ToList();
        }

        [HttpGet("{id}", Name = "GetThread")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Thread thread = await _context.thread
                                        .Include(t => t.channel_id)
                                        .SingleOrDefaultAsync(t => t.channel_id == id);

            if (thread == null)
            {
                return NotFound();
            }

            return Ok(thread);

        }

             [HttpPost]
        public async Task<IActionResult> Post([FromBody] Thread thread)
        {
            if (thread == null)
            {
                return BadRequest();
            }

            _context.thread.Add(thread);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            Thread newThread = await _context.thread
                                .Include(c => c.channel)
                                .SingleOrDefaultAsync(t => t.thread_id == thread.thread_id);
            
            if (newThread == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("GetThread", new {id = thread.thread_id }, newThread);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Thread thread)
        {
            if (thread == null || thread.thread_id != id)
            {
                return BadRequest();
            }

            _context.thread.Update(thread);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Thread item = _context.thread.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.thread.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
