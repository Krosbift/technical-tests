using api_on_off.src.routes.raffleNumbers.repository;
using api_on_off.src.routes.raffleNumbers.model;
using api_on_off.src.shared.methods;

namespace api_on_off.src.routes.raffleNumbers.service
{
    public class RaffleNumberService(RaffleNumberRepository raffleNumberRepository) : IRaffleNumberService
    {
        private readonly RaffleNumberRepository _raffleNumberRepository = raffleNumberRepository;

        /// <summary>
        /// Generates a unique number for a client to participate in a raffle.
        /// </summary>
        /// <param name="ClientId">The ID of the client.</param>
        /// <param name="RaffleId">The ID of the raffle.</param>
        /// <param name="UserId">The ID of the user.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the generated number as a string.</returns>
        public async Task<string> GenerateNumberToParticipate(int ClientId, int RaffleId, int UserId)
        {
            string numberToParticipate;
            while (true)
            {
                numberToParticipate = AssingEncoding(ClientId, RaffleId);
                bool existsNumber = await _raffleNumberRepository.GetSpecificNumber(numberToParticipate, RaffleId, ClientId);
                if (!existsNumber) break;
            }

            RaffleNumber raffleNumber = new()
            {
                Number = numberToParticipate,
                ClientId = ClientId,
                RaffleId = RaffleId,
                UserId = UserId
            };
            _raffleNumberRepository.CreateRaffleNumber(raffleNumber);
            return numberToParticipate;
        }

        /// <summary>
        /// Generates a deterministic encoded string based on the provided ClientId and RaffleId.
        /// </summary>
        /// <param name="ClientId">The unique identifier for the client.</param>
        /// <param name="RaffleId">The unique identifier for the raffle.</param>
        /// <returns>A string representing a 5-digit encoded number, padded with leading zeros if necessary.</returns>
        private static string AssingEncoding(int ClientId, int RaffleId)
        {
            string raffleCode = $"+{RaffleId}{DateTime.Now}{ClientId}+";
            int seed = GenerateHashCode.GetDeterministicHashCode(raffleCode);
            Random random = new(seed);
            int number = random.Next(1, 99999);
            return number.ToString("D5").PadLeft(5, '0');
        }
    }
}