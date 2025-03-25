using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMng.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelMng.Configuration
{
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {


            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();
            builder.Property(r => r.FirstName)
                 .IsRequired()
                 .HasMaxLength(50);
            builder.Property(r => r.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.BirthDay)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Gender)
                .HasMaxLength(10);
            builder.Property(r => r.PhoneNumber)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(r => r.EmailAddress)
                .IsRequired();
            builder.Property(r => r.NumberGuest)
                .IsRequired();
            builder.Property(r => r.Address.State)
                .HasMaxLength(20);
            builder.Property(r => r.Address.City)
                .HasMaxLength(20);
            builder.Property(r => r.Address.StreetAddress)
                .HasMaxLength(50);
            builder.Property(r => r.Address.ZipCode)
                .HasMaxLength(10);
            builder.Property(r => r.Address.AptSuite)
                .HasMaxLength(20);

        }
    }
}
