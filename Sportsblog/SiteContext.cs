using Microsoft.EntityFrameworkCore;
using Sportsblog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog
{
    public class SiteContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Tags> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Sportsblog;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            {
                modelBuilder.Entity<Sports>().HasData(

                    new Sports { SportName = "Soccer", SportId = 1 },

                    new Sports { SportName = "Basketball", SportId = 2 });



                modelBuilder.Entity<Tags>().HasData(

                    new Tags { TagName = "Spoiler", TagId = 1 },

                    new Tags { TagName = "Hot Take", TagId = 2 },

                    new Tags { TagName = "World Cup", TagId = 3 });


                modelBuilder.Entity<Posts>().HasData(

                    new Posts { Title = "USA Women's Team", PostId = 1, PostContent = "The woman will have there hands full with France!", DateTime = "2019, 6, 24", SportId = 1, TagId = 3 },

                    new Posts { Title = "France Goes Down", PostId = 2, PostContent = "USA took care of France with penalty kicks!", DateTime = "2019, 6, 25", SportId = 1, TagId = 1},

                    new Posts { Title = "Cavs", PostId = 4, PostContent = "The Cavs draft class seems to be pretty good", DateTime = "2019, 6, 25", SportId = 2, TagId = 2 },

                    new Posts { Title = "Durant", PostId = 3, PostContent = "Kevin Durant just turned down 31 mil!", DateTime = "2019, 6, 26", SportId = 2, TagId = 2});

            }

        }

    }
}
