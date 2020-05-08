﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Tracker.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FlightNumber { get; set; }
        
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser identityUser { get; set; }
    }
}
