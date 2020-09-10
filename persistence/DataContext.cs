using System;
using domain;
using Microsoft.EntityFrameworkCore;

namespace persistence
{
    public class DataContext : DbContext
    {
        //Constructore with options, missing out 'base' would cause migration problem
        public DataContext(DbContextOptions options):base(options)
        {
            //no need of anything here
        }
        //creating property of entity(value) type to set values,it is the table name
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value{Id = 1, Name = "Value101"},
                new Value{Id = 2, Name = "Value102"}
            );
        }
    }
}
