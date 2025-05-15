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
            var category = await categoryRepository.GetAllByUserIdAsync(request.userId);

            var categoryDtos = category.Select(category => new CategoryDto
            {   
                Id = category.Id,
                Title = category.Title,
                Description = category.Description.ToString(),
            }).ToList();

            return categoryDtos ?? [];
        }
    }
}
