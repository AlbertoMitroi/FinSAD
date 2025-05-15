

namespace FinSAD.Application.Features.Categories.Commands;
using System;
using FinSAD.Application.DTOs;
using FinSAD.Domain.Entities;
using FinSAD.Domain.Interfaces;
using MediatR;
public sealed record CreateCategoryCommand(CategoryPostDto CategoryPostDto, int userId) : IRequest<CategoryDto>;
public class CreateCategoryCommandHandler(
    ICategoryRepository categoryRepository
) : IRequestHandler<CreateCategoryCommand, CategoryDto>
{
    public async Task<CategoryDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category
        {
            Title = request.CategoryPostDto.Title,
            Description = request.CategoryPostDto.Description,
        };

        await categoryRepository.AddAsync(category, request.userId, cancellationToken);

        return new CategoryDto
        {
            Id = category.Id,
            Title = category.Title,
            Description = category.Description,
        };
    }
}