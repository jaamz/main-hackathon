using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/interview")]
    [ApiController]
    public class InterviewController : Controller
    {

        private HackathonDBContext _context;

        public InterviewController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Interview> Get()
        {
            return _context.interview.Include(m => m.appuser).ToList();
        }

        [HttpGet("{id}", Name = "Getpostedmessage")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interview interview = await _context.interview
                                        .Include(m => m.interview_id)
                                        .SingleOrDefaultAsync(m => m.interview_id == id);

            if (interview == null)
            {
                return NotFound();
            }

            return Ok(interview);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Interview interview)
        {
            if (interview == null)
            {
                return BadRequest();
            }

            _context.interview.Add(interview);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            Interview newpostedmessage = await _context.interview
                                .Include(m => m.interview_id)
                                .SingleOrDefaultAsync(t => t.interview_id == interview.interview_id);

            if (newpostedmessage == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("Getpostedmessage", new { id = interview.interview_id }, newpostedmessage);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Interview interview)
        {
            if (interview == null || interview.interview_id != id)
            {
                return BadRequest();
            }

            _context.interview.Update(interview);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Interview item = _context.interview.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.interview.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
