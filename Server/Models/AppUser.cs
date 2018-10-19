using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class AppUser
    {
        [Key]
        public int                  user_id      {get; set;}
        public string               name {get; set;}
        public string               email    {get; set;}
        public string               phone {get; set;}
        [ForeignKey("Company")]
        public int                  company_id  {get; set;}
        public Company              company {get; set;}
        public string               bio  {get; set;}
        public string               user_type {get; set;}

        public AppUser()
        {
            
        }
    }
}