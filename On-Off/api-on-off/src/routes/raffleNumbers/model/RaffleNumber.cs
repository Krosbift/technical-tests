using System.ComponentModel.DataAnnotations;
using api_on_off.src.shared.models;

namespace api_on_off.src.routes.raffleNumbers.model
{
    public class RaffleNumber
    {
        public int Id { get; set; }

        [MaxLength(5, ErrorMessage = "Raffle number must be 5 characters")]
        [MinLength(5, ErrorMessage = "Raffle number must be 5 characters")]
        public string Number { get; set; } = null!;
        
        public int ClientId { get; set; }     
        public Client Client { get; set; } = null!;   
        
        public int RaffleId { get; set; }
        public Raffle Raffle { get; set; } = null!;
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}