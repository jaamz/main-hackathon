using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Interview
    {
        [Key]
        public int interview_id { get; set; }
        public string interview_title { get; set; }
        public string interview_body { get; set; }
        [ForeignKey("appuser_id")]
        public int appuser_id { get; set; }
        public AppUser appuser { get; set; }

        public Interview()
        {

        }
    }
}