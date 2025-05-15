using System.Threading.Tasks;
// using FinSAD.Application.Features.Categories.Commands;
using FinSAD.Application.Features.Categories.Commands; // Update this to the correct namespace if different
using FinSAD.Application.Features.Categories.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FinSAD.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize]
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetCategoriesByUserId(int userId)
        {
            var categories = await _mediator.Send(new GetCategoriesByUserIdQuery(userId));
                return categories?.Count > 0 ?
                    Ok(categories)
                    : NotFound("Categories not found.");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(Create), new { id }, id);
        }
    }
}