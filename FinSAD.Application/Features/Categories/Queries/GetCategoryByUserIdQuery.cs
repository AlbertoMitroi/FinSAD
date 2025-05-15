using FinSAD.Application.DTOs;
using FinSAD.Domain.Interfaces;
using MediatR;

namespace FinSAD.Application.Features.Categories.Queries
{
    public sealed record GetCategoriesByUserIdQuery(int userId) : IRequest<List<CategoryDto>>;
    internal class GetCategoriesByUserIdQueryHandler(
        ICategoryRepository categoryRepository
        ) : IRequestHandler<GetCategoriesByUserIdQuery, List<CategoryDto>>
    {
        public async Task<List<CategoryDto>> Handle(GetCategoriesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var cards = await categoryRepository.GetAllByUserIdAsync(request.userId);

            var categoryDtos = cards.Select(card => new CategoryDto
            {
                Title = category.Title,
                Description = category.Description.ToString(),
                IsCustom = category.IsCustom,
            }).ToList();

            return categoryDtos ?? [];
        }
    }
}
