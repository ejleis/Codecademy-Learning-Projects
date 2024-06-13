using Microsoft.EntityFrameworkCore;
using RazorCountry.Models;


namespace RazorCountry.Data
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { } // Constructor

        public DbSet<Continent> ContinentsDbSet { get; set; }
        public DbSet<Country> CountriesDbSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().ToTable("Continent");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }
}
