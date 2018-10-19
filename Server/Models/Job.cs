using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Jobs
    {
        [Key]
        public int              job_id {get; set;}
        public string           position_title {get; set;}
        public string           employement_type {get; set;}
        [ForeignKey("Company")]
        public int              company_id {get; set;}
        public Company          company {get; set;}

        public Jobs()
        {

        }
    }
}