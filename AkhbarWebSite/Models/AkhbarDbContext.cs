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
    }
}
