using api_on_off.src.routes.raffleNumbers.model;

namespace api_on_off.src.shared.models
{
    public class Raffle
    {
        public int Id { get; set; }

        public ICollection<RaffleNumber> RaffleNumbers { get; set; } = [];
    }
}