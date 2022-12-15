using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Rail_Reserv.Models
{
    public class OurDbContext:DbContext
    {
      public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TrainDetail> TrainDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}