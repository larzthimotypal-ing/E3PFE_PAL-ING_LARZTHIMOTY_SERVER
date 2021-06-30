using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class UserContext : DbContext //dependency injection of the dbcontext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { set; get; }

        protected override void OnModelCreating(ModelBuilder  modelBuilder) // this is used to make it so that the email must be unique 
        {
            modelBuilder.Entity<AppUser>(
                entity => { entity.HasIndex(e => e.Email).IsUnique(); });
        }
    }
}
