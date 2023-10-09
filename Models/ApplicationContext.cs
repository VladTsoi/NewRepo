using Microsoft.EntityFrameworkCore;

namespace Calculator.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PaymentModel> Payments { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
