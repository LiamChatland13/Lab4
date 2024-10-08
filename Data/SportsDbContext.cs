﻿using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class SportsDbContext: DbContext
    {

        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options)
        {
        }

        public DbSet<SportClub> SportClubs { get; set; }
        public DbSet<Fan> Fans { get; set; }

        public DbSet<Subscription> subscriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportClub>().ToTable("SportClub");
            modelBuilder.Entity<Fan>().ToTable("Fan");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");
        }

    }
}
