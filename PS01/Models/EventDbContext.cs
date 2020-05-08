using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS01.Models
{
    public class EventDbContext:DbContext
    {
        public EventDbContext():base("MyConnection")
        {

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}