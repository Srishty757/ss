﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventPlan.Application.Models
{
  
       [Table("EventOrganiserDetails")]
        public  class EventOrganiserDetail
    { 
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        
    }
}

