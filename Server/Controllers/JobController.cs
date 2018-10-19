using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/jobs")]
    [ApiController]
    public class JobController : Controller
    {

        private HackathonDBContext _context;

        public JobController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Jobs> Get()
        {
            return _context.jobs.Include(c => c.company).ToList();
        }

        [HttpGet("{id}", Name = "GetJob")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Jobs job = await _context.jobs
                                        .Include(c => c.company)
                                        .SingleOrDefaultAsync(c => c.jobs_id == id);

            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);

        }

             [HttpPost]
        public async Task<IActionResult> Post([FromBody] Jobs job)
        {
            if (job == null)
            {
                return BadRequest();
            }

            _context.jobs.Add(job);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            Jobs newjob = await _context.jobs
                                .Include(c => c.company)
                                .SingleOrDefaultAsync(c => c.jobs_id == job.jobs_id);
            
            if (newjob == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("Getjob", new {id = job.jobs_id }, newjob);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Jobs jobs)
        {
            if (jobs == null || jobs.jobs_id != id)
            {
                return BadRequest();
            }

            _context.jobs.Update(jobs);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Jobs item = _context.jobs.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.jobs.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
