﻿using FinSAD.Application.Features.Cards.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

            return cards?.Count > 0 ?
                Ok(cards)
                : NotFound("Cards not found.");
        }

        [Authorize]
        [HttpGet("user/{userId}/history")]
        public async Task<IActionResult> GetCardHistory(int userId)
        {
            var cards = await mediator.Send(new GetCardHistoryByUserIdQuery(userId));

            return cards?.Count > 0 ?
                Ok(cards)
                : NotFound("Cards not found.");
        }
    }
}
