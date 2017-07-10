using TestowaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace TestowaMVC.Data
{
    public class TestowyContext : DbContext
    {
        public TestowyContext(DbContextOptions<TestowyContext> options) : base(options)
        {
        }

        public DbSet<Przedmiot> Przedmiot { get; set; }
        public DbSet<Kupno> Kupno { get; set; }
        public DbSet<Sprzedaz> Sprzedaz { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // wymusza nazwy w liczbie pojedynczej
            modelBuilder.Entity<Przedmiot>().ToTable("Przedmiot");
            modelBuilder.Entity<Kupno>().ToTable("Kupno");
            modelBuilder.Entity<Sprzedaz>().ToTable("Sprzedaz");

            // objasnia relacje 1-do-1
            modelBuilder.Entity<Przedmiot>()
            .HasOne(p => p.Kupno)
            .WithOne(k => k.Przedmiot)
            .HasForeignKey<Kupno>(i => i.PrzedmiotID);

            modelBuilder.Entity<Przedmiot>()
            .HasOne(p => p.Sprzedaz)
            .WithOne(k => k.Przedmiot)
            .HasForeignKey<Sprzedaz>(i => i.PrzedmiotID);
        }
    }
}
