using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class CollaborationBoard
    {
        [Key]
        public int              collabboard_id {get; set;}
        public CollaborationBoard()
        {

        }
    }
}