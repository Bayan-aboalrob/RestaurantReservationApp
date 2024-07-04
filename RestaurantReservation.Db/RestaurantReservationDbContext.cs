using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             "Data Source=DESKTOP-HOSEMG4;Initial Catalog=RestaurantReservationCore1;Integrated Security=True;TrustServerCertificate=True;"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .OwnsOne(r => r.Address);

            base.OnModelCreating(modelBuilder);
        }
    }
}