using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Thread
    {
        [Key]
        public int              thread_id {get; set;}
        public string           thread_title {get; set;}
        [ForeignKey("appuser_id")]
        public int              appuser_id{get; set;}
        public AppUser          appuser {get; set;}
        public Thread()
        {

        }
    }
}