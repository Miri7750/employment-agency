using eployment__agency.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eployment__agency.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Brokerage> Brokerages { get; set; }
        public DbSet<Business> Businesses { get; set; } 
        public DbSet<Jub>Jubs { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Debug.Write(mesege));
        }

    }
}
