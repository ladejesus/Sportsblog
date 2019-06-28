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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            {
                modelBuilder.Entity<Sports>().HasData(

                    new Sports { SportName = "Soccer", SportId = 1 },

                    new Sports { SportName = "Basketball", SportId = 2});



                modelBuilder.Entity<Tags>().HasData(

                    new Tags { TagName = "Spoiler", TagId = 1 },

                    new Tags { TagName = "Hot Take", TagId = 2 },

                    new Tags { TagName = "World Cup", TagId = 3 });


            }

        }

    }

