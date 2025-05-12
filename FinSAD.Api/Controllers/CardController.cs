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
    }
}
