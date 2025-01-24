using Microsoft.AspNetCore.Mvc;
using api_on_off.src.routes.raffleNumbers.service;

namespace api_on_off.src.routes.raffleNumbers
{
    [Route("raffle-number")]
    [ApiController]
    public class RaffleNumberController(RaffleNumberService raffleNumberService) : ControllerBase
    {
        private readonly RaffleNumberService _raffleNumberService = raffleNumberService;

        [HttpPost]
        [Route("generate-number-to-participate/{ClientId}/{RaffleId}/{UserId}")]
        public async Task<IActionResult> GenerateNumberToParticipateAsync([FromRoute] int ClientId, [FromRoute] int RaffleId, [FromRoute] int UserId)
        {
            return Ok(await _raffleNumberService.GenerateNumberToParticipate(ClientId, RaffleId, UserId));
        }
    }
}