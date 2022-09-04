using System;
using CIS174EntityFrameworkDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace CIS174EntityFrameworkDemo
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base (options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }

        //protected override void onConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer(@"")
    }
}

