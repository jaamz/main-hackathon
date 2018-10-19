using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Collaboration
    {
        [Key]
        public int              collaboration_id {get; set;}
        public string           collaboration_title {get; set;}
        public string           collaboration_body {get; set;}
        [ForeignKey("appuser_id")]
        public int              appuser_id{get; set;}
        public AppUser          appuser {get; set;}
        public Collaboration()
        {
            
        }
    }
}