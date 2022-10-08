using Microsoft.EntityFrameworkCore;

namespace carsBackEnd.Models
{
    // *** No database yet this is a template on what we want to do ***
    public class DataBaseContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Car> car { get; set; }
        public DbSet<Engine> engine { get; set; }
        public DbSet<Dealership> dealership { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}