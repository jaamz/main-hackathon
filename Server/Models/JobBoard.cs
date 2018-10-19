using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class JobBoard
    {
        [Key]
        public int              jobboard_id {get; set;}
        public JobBoard()
        {

        }
    }
}