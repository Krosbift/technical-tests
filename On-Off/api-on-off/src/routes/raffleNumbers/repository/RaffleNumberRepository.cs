using api_on_off.src.routes.raffleNumbers.context;
using api_on_off.src.routes.raffleNumbers.model;
using Microsoft.EntityFrameworkCore;

namespace api_on_off.src.routes.raffleNumbers.repository
{
    public class RaffleNumberRepository(RaffleNumbersContext context) : IRaffleNumberRepository
    {
        private readonly RaffleNumbersContext _context = context;

        /// <summary>
        /// Checks if a specific raffle number exists for a given raffle and client.
        /// </summary>
        /// <param name="Number">The raffle number to check.</param>
        /// <param name="RaffleId">The ID of the raffle.</param>
        /// <param name="ClientId">The ID of the client.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the specific raffle number exists.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while retrieving the raffle number.</exception>
        public async Task<bool> GetSpecificNumber(string Number, int RaffleId, int ClientId)
        {
            try
            {
                return await _context.RaffleNumbers.AnyAsync(rn => rn.Number == Number && rn.RaffleId == RaffleId && rn.ClientId == ClientId);
            }
            catch (Exception)
            {
                throw new Exception("Error to get specific number");
            }
        }

        /// <summary>
        /// Asynchronously creates a new raffle number and saves it to the database.
        /// </summary>
        /// <param name="raffleNumber">The raffle number entity to be created.</param>
        /// <exception cref="Exception">Thrown when there is an error creating the raffle number.</exception>
        public async Task<bool> CreateRaffleNumber(RaffleNumber raffleNumber)
        {
            try
            {
                _context.RaffleNumbers.Add(raffleNumber);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                if (await _context.RaffleNumbers.AnyAsync(r => r.Number == raffleNumber.Number && r.RaffleId == raffleNumber.RaffleId))
                {
                    throw new InvalidOperationException("Raffle number already exists.");
                }
                return true;
            }
        }
    }
}