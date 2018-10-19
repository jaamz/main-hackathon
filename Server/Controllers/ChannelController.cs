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
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Channel chan = _context.channel.Find(id);

            if ( chan == null ) {
                return BadRequest();
            }
            return Ok(chan);

        }

        [HttpPost]
        public IActionResult Create([FromBody]Channel channel)
        {
            if (channel == null) 
            {
                return BadRequest();
            }
            _context.channel.Add(channel);
            _context.SaveChanges();
            return Ok(channel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody]Channel channel)
        {
            Channel item = _context.channel.Find(id);
            
            if (channel == null)
            {
                return NotFound();
            }

            _context.channel.Remove(item);
            _context.channel.Add(channel);
            _context.SaveChanges();

            return Ok(channel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Channel item = _context.channel.Find(id);
            
            if (item == null)
            {
                return NotFound();
            }

            _context.channel.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }


     }
}
