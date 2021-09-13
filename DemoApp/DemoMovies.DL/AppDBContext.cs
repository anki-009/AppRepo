using Microsoft.EntityFrameworkCore;
using DemoMovies.DL.Entity;
using Movies.Repository.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.DL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            
        }
    }
}
