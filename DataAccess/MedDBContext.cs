using Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MedDBContext : DbContext
    {
        public MedDBContext (DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Header> Headers { get; set; }

        public DbSet<MobApp> MobApps { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Countdown> Countdowns { get; set; }
        public DbSet<Quality> Qualities { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Tags> Tags { get; set; }

        public DbSet<Reguest> Reguests { get; set; }


    }
}
