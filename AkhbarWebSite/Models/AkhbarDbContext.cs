using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AkhbarWebSite.Models
{
    public class AkhbarDbContext : DbContext
    {
        public AkhbarDbContext(DbContextOptions<AkhbarDbContext> options)
            :base(options)
        {

        }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //another method to have auto generated value
            //modelBuilder.Entity<News>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<News>()
                .Property(b => b.Id)
                .HasDefaultValueSql("newid()");
            modelBuilder.Entity<Category>()
                .Property(b => b.Id)
                .HasDefaultValueSql("newid()");
            modelBuilder.Entity<ContactUs>()
                .Property(b => b.Id)
                .HasDefaultValueSql("newid()");
            modelBuilder.Entity<TeamMember>()
                .Property(b => b.Id)
                .HasDefaultValueSql("newid()");

            base.OnModelCreating(modelBuilder);
        }
    }
}
