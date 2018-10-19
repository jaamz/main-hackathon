using System;
using System.ComponentModel.DataAnnotations;

namespace Server
{
    public class Company
    {
        [Key]
        public int      company_id {get; set;}
        public string   company_name {get; set;}
        public string   company_phone {get; set;}
        public string   company_address {get; set;}
        public string   company_notes {get; set;}
        // [ForgeinKey("Detail")]

        public Company()
        {
            
        }
    }
}