using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMng.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelMng.Data
{
    internal class HotelMngContext : DbContext
    {
       
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = HotelMng; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");


            public DbSet<Kitchen> Kitchens { get; set; }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Reservation> reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().
                    HasKey(u=>u.UserName);
                
                modelBuilder.Entity<User>().
                    Property(u => u.UserName).IsRequired()
                    .HasMaxLength(20);

                modelBuilder.Entity<User>().
                    Property(u => u.Password).IsRequired()
                    .HasMaxLength(30);

                modelBuilder.Entity<User>()
                  .HasDiscriminator<string>("UserType")
                  .HasValue<User>("User")
                  .HasValue<Admin>("Admin")
                  .HasValue<Kitchen>("Kitchen");



            }
        
    }
}
