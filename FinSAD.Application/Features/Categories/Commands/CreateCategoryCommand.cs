using FinSAD.Application.Features.Categories.DTOs;
using FinSAD.Domain.Entities;
using MediatR;

namespace FinSAD.Application.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}