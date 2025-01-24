using System.ComponentModel.DataAnnotations;
using api_on_off.src.routes.raffleNumbers.model;

namespace api_on_off.src.shared.models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name must be less than 100 characters")]
        public string Name { get; set; } = null!;

        public ICollection<RaffleNumber> RaffleNumbers { get; set; } = [];
    }
}