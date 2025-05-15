using System.Threading.Tasks;
using FinSAD.Application.Categories.Commands;
using FinSAD.Application.Categories.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CategoriesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [Authorize]
    [HttpGet("/categories")]
    public async Task<IActionResult> GetCategoriesByUserId(int userId)
    {
        var categories = await mediator.Send(new GetCategoriesByUserIdQuery(userId);
            return categories?.Count > 0 ?
                Ok(categories)
                : NotFound("Categories not found.");
    }

    //public async Task<IActionResult> GetCardsByUserId(int userId)
    //{
    //    var cards = await mediator.Send(new GetCardsByUserIdQuery(userId));

    //    return cards?.Count > 0 ?
    //        Ok(cards)
    //        : NotFound("Cards not found.");
    //}
    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(Create), new { id }, id);
    }
}
