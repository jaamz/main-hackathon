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


        public IActionResult Get()
        {
            if (_context.jobs.ToList().Count == 0)
            {
                return NotFound();
            }

            return Ok(_context.jobs.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Jobs j = _context.jobs.Find(id);

            if ( j == null ) {
                return BadRequest();
            }
            return Ok(j);

        }

        [HttpPost]
<<<<<<< HEAD
        public async Task<IActionResult> Post([FromBody] Jobs job)
=======
        public IActionResult Create([FromBody]Jobs job)
>>>>>>> Lucas-Working-Branch
        {
            if (job == null) 
            {
                return BadRequest();
            }
            _context.jobs.Add(job);
            _context.SaveChanges();
<<<<<<< HEAD

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            Jobs newjob = await _context.jobs
                                .Include(c => c.company)
                                .SingleOrDefaultAsync(c => c.jobs_id == job.jobs_id);

            if (newjob == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("Getjob", new { id = job.jobs_id }, newjob);
=======
            return Ok(job);
>>>>>>> Lucas-Working-Branch
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody]Jobs job)
        {
            Jobs item = _context.jobs.Find(id);
            
            if (job == null)
            {
                return NotFound();
            }

            _context.jobs.Remove(item);
            _context.jobs.Add(job);
            _context.SaveChanges();

            return Ok(job);
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
