using Forsaj.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models
{
    public class ForsajContext : DbContext
    {
        public ForsajContext(DbContextOptions<ForsajContext> options) : base(options)
        {
        }
        public DbSet<Login_Log> Login_Logs { get; set; }
        public DbSet<Ban_Type>  Ban_Types { get; set; }
        public DbSet<Cars_Details> Cars_Details { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Fuel_Type>  Fuel_Types { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model_Cars> Model_Cars { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Speed_Type> Speed_Types { get; set; }
        public DbSet<Telefon> Telefons{ get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post_Images> Post_Images { get; set; }
        public DbSet<Details> Details { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<UserAndRole> UserAndRoles { get; set; }
        public DbSet<UserAndTelefon> UserAndTelefons { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login_Log>()
             .Property(b => b.CreateDate)
             .HasDefaultValueSql("GETDATE()");

        }
    }
}
