using System.Threading.Tasks;
// using FinSAD.Application.Features.Categories.Commands;
using FinSAD.Application.Features.Categories.Commands; // Update this to the correct namespace if different
using FinSAD.Application.Features.Categories.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FinSAD.Application.DTOs;


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

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryPostDto categoryPostDto, int userId)
        {
            if (categoryPostDto == null)
            {
                return BadRequest("Invalid category data.");
            }

            var result = await _mediator.Send(new CreateCategoryCommand(categoryPostDto, userId));

            return CreatedAtAction(nameof(GetCategoriesByUserId), new { userId = result.UserId }, result);
        }
    }
}