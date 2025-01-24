namespace api_on_off.src.routes.raffleNumbers.service
{
    public interface IRaffleNumberService
    {
        Task<string> GenerateNumberToParticipate(int ClientId, int RaffleId, int UserId);
    }
}