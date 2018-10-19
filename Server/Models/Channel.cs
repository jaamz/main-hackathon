using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Channel
    {
        [Key]
        public int              channel_id {get; set;}
        public string           name {get; set;}
        public Channel()
        {

        }
    }
}