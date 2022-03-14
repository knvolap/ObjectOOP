using Microsoft.EntityFrameworkCore;

namespace ObjectOrientedProgramming.Models
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options) : base(options)
        {

        }
        public DbSet<Address> addresse { get; set; } = null!;
    }
    
}
