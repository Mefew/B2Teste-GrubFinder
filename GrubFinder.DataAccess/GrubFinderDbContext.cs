using GrubFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GrubFinder.DataAccess
{
    public class GrubFinderDbContext : DbContext
    {
        public GrubFinderDbContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Customer> Customers {  get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<Restaurant> Restaurants {  get; set; }
    }
}
