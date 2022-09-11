using Microsoft.EntityFrameworkCore;
using NET_razor_pages_application.Models;

namespace NET_razor_pages_application.Data
{
    public class ApplicationDbContext: DbContext
    {
        // PizzaOrders is a table in the database
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
    }
}
