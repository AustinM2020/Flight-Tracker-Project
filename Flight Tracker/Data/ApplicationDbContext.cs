using System;
using System.Collections.Generic;
using System.Text;
using Flight_Tracker.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
=======
>>>>>>> 7ed97ece153bbe3a49e8891ec66abe793d9692f6
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flight_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FlightTracker> Flights { get; set; }
    }  
=======
        public DbSet<Customer> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
>>>>>>> 7ed97ece153bbe3a49e8891ec66abe793d9692f6
}
