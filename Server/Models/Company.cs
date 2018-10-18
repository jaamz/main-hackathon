using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class Company
    {
        [Key]
        public int          company_id {get; set;}
        public string       company_name {get; set;}
        public int          company_phone {get; set;}
        public string       company_address {get; set;}
        public string       company_notes {get; set;}
        public Company()
        {
            
        }
    }
}