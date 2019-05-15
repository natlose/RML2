using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RML_EF
{
    class Entities : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(  // Ehhez kell a Microsoft.EntitFrameworkCore.SqlServer NuGet csomag
                ConfigurationManager.ConnectionStrings["RMLaborDB"].ConnectionString // Ehhez kell a System.Configuration.ConfigurationManager NuGet csomag
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Person
            //A #region egy VS trükk: becsukható szakaszok a forráskódban
            modelBuilder.Entity<Person>().Property(p => p.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Person>().Property(p => p.Titles)
                .HasMaxLength(10)
                .IsUnicode();
            modelBuilder.Entity<Person>().Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode();
            modelBuilder.Entity<Person>().Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode();
            modelBuilder.Entity<Person>().Property(p => p.Phone)
                .HasMaxLength(30);
            modelBuilder.Entity<Person>().Property(p => p.Mobile)
                .HasMaxLength(30);
            modelBuilder.Entity<Person>().Property(p => p.Email)
                .HasMaxLength(80);
            modelBuilder.Entity<Person>().ToTable("Person");  // Ehhez telepíteni kell a Microsoft.EntityFrameworkCore.Relational NuGet csomagot is!
            #endregion

            #region Address
            modelBuilder.Entity<Address>().Property(b => b.Kind)
                .IsRequired()
                .HasColumnType("char(10)")
                .HasDefaultValue()
                .HasConversion(new EnumToStringConverter<AddressKind>());
            modelBuilder.Entity<Address>().Property(a => a.Country3166)
                .IsRequired()
                .HasMaxLength(2);
            modelBuilder.Entity<Address>().Property(a => a.Zip)
                .IsRequired()
                .HasMaxLength(10);
            modelBuilder.Entity<Address>().Property(a => a.City)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(a => a.Line1)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(a => a.Line2)
                .HasMaxLength(30);
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Person)
                .WithMany(p => p.Addresses)
                .HasForeignKey(a => a.FI_Person);
            modelBuilder.Entity<Address>().ToTable("Address");
            #endregion

        }
    }
}
