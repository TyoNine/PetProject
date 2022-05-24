using FitnessClub.Core;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure
{
    public class FitnessClubContext : DbContext
    {
        public FitnessClubContext(DbContextOptions<FitnessClubContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Gym> Gym { get; set; }

        public DbSet<Customer> Customer { get; set; }
    }
}
