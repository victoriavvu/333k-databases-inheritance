﻿using System;
using Microsoft.EntityFrameworkCore;


using Vu_Victoria_HW4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Vu_Victoria_HW4.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
