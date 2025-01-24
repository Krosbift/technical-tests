using api_on_off.src.routes.raffleNumbers.model;

namespace api_on_off.src.routes.raffleNumbers.repository
{
    public interface IRaffleNumberRepository
    {
        Task<bool> GetSpecificNumber(string Number, int RaffleId, int ClientId);
        Task<bool> CreateRaffleNumber(RaffleNumber raffleNumber);
    }
}