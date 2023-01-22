using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkIT.Entities
{
    public class MarkITContext : DbContext
    {
        public MarkITContext(DbContextOptions<MarkITContext> options): base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Task> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            

            //ONE TO MANY USER-GROUP
            builder.Entity<User>()
                 .HasMany(u => u.Groups)
                 .WithOne(g => g.User);

            //ONE TO MANY GROUP-LIST
            builder.Entity<Group>()
                 .HasMany(g => g.Lists)
                 .WithOne(l => l.Group);

            //ONE TO MANY LIST-TASK
            builder.Entity<List>()
                 .HasMany(l => l.Tasks)
                 .WithOne(t => t.List);

        }
    }
}
