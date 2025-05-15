using AutoMapper;
using FinSAD.Domain.Entities;

namespace FinSAD.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int UserId { get; set; }
    }

    public class CategoryDtoProfile : Profile
    {
        public CategoryDtoProfile()
        {
                CreateMap<Category, CategoryDto>();
        }
    }
}
