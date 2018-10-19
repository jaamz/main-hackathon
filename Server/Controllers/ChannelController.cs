using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/channels")]
    [ApiController]
    public class ChannelController : Controller
    {

        private HackathonDBContext _context;

        public ChannelController(HackathonDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            if (_context.channel.ToList().Count == 0)
            {
                return NotFound();
            }

            return Ok(_context.channel.ToList());
        }

        // [HttpGet("{id}")]
        // public IActionResult GetById(int id)
        // {
        //     Company c = _context.company.Find(id);

        //     if ( c == null ) {
        //         return BadRequest();
        //     }
        //     return Ok(c);

        // }

        // [HttpPost]
        // public IActionResult Create([FromBody]Company company)
        // {
        //     if (company == null) 
        //     {
        //         return BadRequest();
        //     }
        //     _context.company.Add(company);
        //     _context.SaveChanges();
        //     return Ok(company);
        // }

        // [HttpPut("{id}")]
        // public IActionResult UpdateById(int id, [FromBody]Company company)
        // {
        //     Company item = _context.company.Find(id);
            
        //     if (company == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.company.Remove(item);
        //     _context.company.Add(company);
        //     _context.SaveChanges();

        //     return Ok(company);
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Delete(int id)
        // {
        //     Company item = _context.company.Find(id);
            
        //     if (item == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.company.Remove(item);
        //     _context.SaveChanges();
        //     return Ok(item);
        // }


     }
}
