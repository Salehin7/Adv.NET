using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class SSBContext : DbContext
    {
        public DbSet<Stadium> Stadiums { get; set;}
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Revenue> Revenues { get; set; }

        public DbSet<Janitor> Janitors { get; set;}

    }
}
