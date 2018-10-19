using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class PostedMessage
    {
        [Key]
        public int              message_id {get; set;}
        public string           message_title {get; set;}
        public string           message_content {get; set;}
        [ForeignKey("thread_id")]
        public int              thread_id     {get; set;}
        public Thread          thread {get; set;}
        [ForeignKey("appuser_id")]
        public int              appuser_id{get; set;}
        public AppUser          appuser {get; set;}
        public string           message_time {get; set;}
        public PostedMessage()
        {

        }
    }
}