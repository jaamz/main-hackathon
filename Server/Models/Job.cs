using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Jobs
    {
        [Key]
        public int              jobs_id {get; set;}
        public string           position_title {get; set;}
        public string           employment_type {get; set;}
        public string           company_name {get; set;}

        public Jobs()
        {

        }
    }
}