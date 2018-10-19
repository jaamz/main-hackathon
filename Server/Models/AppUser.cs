using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class AppUser
    {
        [Key]
        public int                  appuser_id      {get; set;}
        public string               name {get; set;}
        public string               username {get; set;}
        public string               password {get; set;}
        public string               email    {get; set;}
        // public string               password {get; set;}
        public string               phone {get; set;}

        public string               company_name {get; set;}
        public string               bio  {get; set;}
        public string               user_type {get; set;}

        public AppUser()
        {
            
        }
    }
}