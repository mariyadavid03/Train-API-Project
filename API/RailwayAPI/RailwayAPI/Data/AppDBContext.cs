using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RailwayAPI.Model;
namespace RailwayAPI.Data
{
    public class AppDBContext : DbContext

    {

        public AppDBContext(DbContextOptions<AppDBContext> options) 
            : base(options)
        {

        }

        //Defining Tables
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<Seat> seats { get; set; }
        public DbSet<Train> trains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>();
            modelBuilder.Entity<Class>();
            modelBuilder.Entity<Schedule>();
            modelBuilder.Entity<Train>();
            modelBuilder.Entity<Seat>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string conn = "Data Source=DESKTOP-H788HM6\\MCMSQL;Initial Catalog=railway;User ID=sa;Password=sql;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=Yes;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False;Integrated Security=False";
            optionsBuilder.UseSqlServer(conn);
        }
        

       

       
    }
}
