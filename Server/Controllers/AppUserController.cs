using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/users")]
    [ApiController]
    public class AppUserController : Controller
    {

        private HackathonDBContext _context;

        public AppUserController(HackathonDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<AppUser> Get()
        {
            return _context.appuser.Include(c => c.company).ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser user = await _context.appuser
                                        .Include(c => c.company)
                                        .SingleOrDefaultAsync(c => c.appuser_id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);

        }

             [HttpPost]
        public async Task<IActionResult> Post([FromBody] AppUser user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _context.appuser.Add(user);
            _context.SaveChanges();

            // Grab the newly created job such that can return below in "CreatedAtRoute"
            AppUser newUser = await _context.appuser
                                .Include(c => c.company)
                                .SingleOrDefaultAsync(c => c.appuser_id == user.appuser_id);
            
            if (newUser == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute("Getjob", new {id = user.appuser_id }, newUser);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AppUser user)
        {
            if (user == null || user.appuser_id != id)
            {
                return BadRequest();
            }

            _context.appuser.Update(user);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AppUser item = _context.appuser.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.appuser.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


    }
}
