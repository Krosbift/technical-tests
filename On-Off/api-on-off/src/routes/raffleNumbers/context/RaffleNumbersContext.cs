using api_on_off.src.routes.raffleNumbers.model;
using Microsoft.EntityFrameworkCore;

namespace api_on_off.src.routes.raffleNumbers.context
{
    public class RaffleNumbersContext(DbContextOptions<RaffleNumbersContext> options) : DbContext(options)
    {
        public DbSet<RaffleNumber> RaffleNumbers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<RaffleNumber>()
                .HasOne(rn => rn.Raffle)
                .WithMany(r => r.RaffleNumbers)
                .HasForeignKey(rn => rn.RaffleId);

            modelBuilder.Entity<RaffleNumber>()
                .HasOne(rn => rn.Client)
                .WithMany(c => c.RaffleNumbers)
                .HasForeignKey(rn => rn.ClientId);
            
            modelBuilder.Entity<RaffleNumber>()
                .HasOne(rn => rn.User)
                .WithMany(u => u.RaffleNumbers)
                .HasForeignKey(rn => rn.UserId);
        }
    }
}