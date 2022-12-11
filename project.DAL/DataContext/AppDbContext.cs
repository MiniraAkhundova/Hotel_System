using Microsoft.EntityFrameworkCore;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.DataContext
{
   public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasOne(m => m.Role).WithMany(m => m.Users);

            modelBuilder.Entity<Administrators>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Floor>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Room>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Guests>().HasQueryFilter(m => !m.IsDeleted);
        }
        public DbSet<Administrators> Administrators { get; set; }
        public DbSet<Floor> Floor { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Guests> Guests { get; set; }
    }
}
