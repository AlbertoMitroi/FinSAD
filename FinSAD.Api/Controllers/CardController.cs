using FinSAD.Application.Features.Cards.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinSAD.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController(IMediator mediator) : ControllerBase
    {
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetCardsByUserId(int userId)
        {
            var cards = await mediator.Send(new GetCardsByUserIdQuery(userId));
            return Ok(cards);
        }

        [HttpGet("user/{userId}/history")]
        public async Task<IActionResult> GetCardHistory(int userId)
        {
            var query = new GetCardHistoryByUserIdQuery(userId);
            var result = await mediator.Send(query);

            if (result == null || !result.Any())
            {
                return NotFound("Cards not found.");
            }

            return Ok(result);
        }
    }
}
