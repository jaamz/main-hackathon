using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class InterviewBoard
    {
        [Key]
        public int              intboard_id {get; set;}
        public InterviewBoard()
        {

        }
    }
}